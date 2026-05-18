using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace viviro_final
{
    public class PlantaDAL
    {
        public static List<Planta> ObtenerTodasLasPlantas()
        {
            List<Planta> lista = new List<Planta>();
            string query = "SELECT * FROM Plantas WHERE Activo = 1 ORDER BY NombrePlanta, Especie";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Planta
                {
                    Id = Convert.ToInt32(row["Id"]),
                    NombrePlanta = row["NombrePlanta"].ToString(),
                    Especie = row["Especie"].ToString(),
                    FechaRegistro = Convert.ToDateTime(row["FechaRegistro"]),
                    Activo = Convert.ToBoolean(row["Activo"])
                });
            }
            return lista;
        }

        public static Planta ObtenerPlantaPorId(int id)
        {
            string query = "SELECT * FROM Plantas WHERE Id = @id";
            MySqlParameter[] parameters = { new MySqlParameter("@id", id) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Planta
                {
                    Id = Convert.ToInt32(row["Id"]),
                    NombrePlanta = row["NombrePlanta"].ToString(),
                    Especie = row["Especie"].ToString(),
                    FechaRegistro = Convert.ToDateTime(row["FechaRegistro"]),
                    Activo = Convert.ToBoolean(row["Activo"])
                };
            }
            return null;
        }

        public static bool ExistePlanta(string nombrePlanta, string especie, int idExcluir = 0)
        {
            try
            {
                string query = @"SELECT COUNT(*) FROM Plantas 
                                WHERE NombrePlanta = @nombre 
                                AND (Especie = @especie OR (Especie IS NULL AND @especie = ''))
                                AND Id != @idExcluir";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@nombre", nombrePlanta),
                    new MySqlParameter("@especie", string.IsNullOrEmpty(especie) ? "" : especie),
                    new MySqlParameter("@idExcluir", idExcluir)
                };
                object resultado = DatabaseHelper.ExecuteScalar(query, parameters);
                int count = Convert.ToInt32(resultado);
                return count > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al validar planta: {ex.Message}");
                return false;
            }
        }

        public static int AgregarPlanta(string nombrePlanta, string especie)
        {
            try
            {
                if (ExistePlanta(nombrePlanta, especie))
                {
                    System.Windows.Forms.MessageBox.Show(
                        $"⚠️ Ya existe la planta '{nombrePlanta}' con la especie '{(string.IsNullOrEmpty(especie) ? "Sin especie" : especie)}'.",
                        "Planta Duplicada",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return -1;
                }

                string query = "INSERT INTO Plantas (NombrePlanta, Especie) VALUES (@nombre, @especie)";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@nombre", nombrePlanta),
                    new MySqlParameter("@especie", string.IsNullOrEmpty(especie) ? "" : especie)
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al agregar planta: {ex.Message}");
                return -1;
            }
        }

        public static int ObtenerIdPlanta(string nombrePlanta, string especie)
        {
            string query = "SELECT Id FROM Plantas WHERE NombrePlanta = @nombre AND (Especie = @especie OR (Especie IS NULL AND @especie = ''))";
            MySqlParameter[] parameters = {
                new MySqlParameter("@nombre", nombrePlanta),
                new MySqlParameter("@especie", string.IsNullOrEmpty(especie) ? "" : especie)
            };
            object resultado = DatabaseHelper.ExecuteScalar(query, parameters);
            return resultado != null ? Convert.ToInt32(resultado) : -1;
        }

        public static int ObtenerOCrearPlanta(string nombrePlanta, string especie)
        {
            int id = ObtenerIdPlanta(nombrePlanta, especie);
            if (id == -1)
            {
                AgregarPlanta(nombrePlanta, especie);
                id = ObtenerIdPlanta(nombrePlanta, especie);
            }
            return id;
        }
    }
}