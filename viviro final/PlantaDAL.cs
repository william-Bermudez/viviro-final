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
                                AND Id != @idExcluir
                                AND Activo = 1";
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

        public static bool ActualizarPlanta(Planta planta)
        {
            try
            {
                if (ExistePlanta(planta.NombrePlanta, planta.Especie, planta.Id))
                {
                    System.Windows.Forms.MessageBox.Show(
                        $"⚠️ Ya existe otra planta con el nombre '{planta.NombrePlanta}' y especie '{(string.IsNullOrEmpty(planta.Especie) ? "Sin especie" : planta.Especie)}'.",
                        "Planta Duplicada",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return false;
                }

                string query = "UPDATE Plantas SET NombrePlanta = @nombre, Especie = @especie WHERE Id = @id";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@id", planta.Id),
                    new MySqlParameter("@nombre", planta.NombrePlanta),
                    new MySqlParameter("@especie", string.IsNullOrEmpty(planta.Especie) ? "" : planta.Especie)
                };
                int resultado = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al actualizar planta: {ex.Message}");
                return false;
            }
        }

        public static bool EliminarPlanta(int id)
        {
            try
            {
                string query = "UPDATE Plantas SET Activo = 0 WHERE Id = @id";
                MySqlParameter[] parameters = { new MySqlParameter("@id", id) };
                int resultado = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al eliminar planta: {ex.Message}");
                return false;
            }
        }

        public static int ObtenerIdPlanta(string nombrePlanta, string especie)
        {
            string query = "SELECT Id FROM Plantas WHERE NombrePlanta = @nombre AND (Especie = @especie OR (Especie IS NULL AND @especie = '')) AND Activo = 1";
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
                string query = "INSERT INTO Plantas (NombrePlanta, Especie) VALUES (@nombre, @especie)";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@nombre", nombrePlanta),
                    new MySqlParameter("@especie", string.IsNullOrEmpty(especie) ? "" : especie)
                };
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                id = ObtenerIdPlanta(nombrePlanta, especie);
            }
            return id;
        }
    }
}