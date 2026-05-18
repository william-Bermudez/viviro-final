using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace viviro_final
{
    public class TareaDAL
    {
        public static List<Tarea> ObtenerTareas()
        {
            List<Tarea> lista = new List<Tarea>();
            string query = @"SELECT t.*, p.NombrePlanta, p.Especie 
                            FROM Tareas t 
                            JOIN Plantas p ON t.PlantaId = p.Id 
                            ORDER BY t.FechaInicio ASC, t.HoraRecuerdo ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Tarea
                {
                    Id = Convert.ToInt32(row["Id"]),
                    PlantaId = Convert.ToInt32(row["PlantaId"]),
                    NombrePlanta = row["NombrePlanta"].ToString(),
                    Especie = row["Especie"].ToString(),
                    TipoAccion = row["TipoAccion"].ToString(),
                    Prioridad = row["Prioridad"].ToString(),
                    Ubicacion = row["Ubicacion"].ToString(),
                    FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                    FechaFinalizacion = Convert.ToDateTime(row["FechaFinalizacion"]),
                    Repeticion = row["Repeticion"].ToString(),
                    HoraRecuerdo = TimeSpan.Parse(row["HoraRecuerdo"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Fotos = row["Fotos"].ToString(),
                    Completado = Convert.ToBoolean(row["Completado"])
                });
            }
            return lista;
        }

        public static Tarea ObtenerTareaPorId(int id)
        {
            string query = @"SELECT t.*, p.NombrePlanta, p.Especie 
                            FROM Tareas t 
                            JOIN Plantas p ON t.PlantaId = p.Id 
                            WHERE t.Id = @id";
            MySqlParameter[] parameters = { new MySqlParameter("@id", id) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Tarea
                {
                    Id = Convert.ToInt32(row["Id"]),
                    PlantaId = Convert.ToInt32(row["PlantaId"]),
                    NombrePlanta = row["NombrePlanta"].ToString(),
                    Especie = row["Especie"].ToString(),
                    TipoAccion = row["TipoAccion"].ToString(),
                    Prioridad = row["Prioridad"].ToString(),
                    Ubicacion = row["Ubicacion"].ToString(),
                    FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                    FechaFinalizacion = Convert.ToDateTime(row["FechaFinalizacion"]),
                    Repeticion = row["Repeticion"].ToString(),
                    HoraRecuerdo = TimeSpan.Parse(row["HoraRecuerdo"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Fotos = row["Fotos"].ToString(),
                    Completado = Convert.ToBoolean(row["Completado"])
                };
            }
            return null;
        }

        public static List<Tarea> ObtenerTareasPendientes()
        {
            List<Tarea> lista = new List<Tarea>();
            string query = @"SELECT t.*, p.NombrePlanta, p.Especie 
                            FROM Tareas t 
                            JOIN Plantas p ON t.PlantaId = p.Id 
                            WHERE t.Completado = 0 
                            ORDER BY t.FechaInicio ASC, t.HoraRecuerdo ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Tarea
                {
                    Id = Convert.ToInt32(row["Id"]),
                    PlantaId = Convert.ToInt32(row["PlantaId"]),
                    NombrePlanta = row["NombrePlanta"].ToString(),
                    Especie = row["Especie"].ToString(),
                    TipoAccion = row["TipoAccion"].ToString(),
                    Prioridad = row["Prioridad"].ToString(),
                    Ubicacion = row["Ubicacion"].ToString(),
                    FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                    FechaFinalizacion = Convert.ToDateTime(row["FechaFinalizacion"]),
                    Repeticion = row["Repeticion"].ToString(),
                    HoraRecuerdo = TimeSpan.Parse(row["HoraRecuerdo"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Fotos = row["Fotos"].ToString(),
                    Completado = Convert.ToBoolean(row["Completado"])
                });
            }
            return lista;
        }

        public static List<Tarea> ObtenerTareasPorPrioridad(string prioridad)
        {
            List<Tarea> lista = new List<Tarea>();
            string query = @"SELECT t.*, p.NombrePlanta, p.Especie 
                            FROM Tareas t 
                            JOIN Plantas p ON t.PlantaId = p.Id 
                            WHERE t.Prioridad = @prioridad 
                            ORDER BY t.FechaInicio ASC";
            MySqlParameter[] parameters = { new MySqlParameter("@prioridad", prioridad) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Tarea
                {
                    Id = Convert.ToInt32(row["Id"]),
                    PlantaId = Convert.ToInt32(row["PlantaId"]),
                    NombrePlanta = row["NombrePlanta"].ToString(),
                    Especie = row["Especie"].ToString(),
                    TipoAccion = row["TipoAccion"].ToString(),
                    Prioridad = row["Prioridad"].ToString(),
                    Ubicacion = row["Ubicacion"].ToString(),
                    FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                    FechaFinalizacion = Convert.ToDateTime(row["FechaFinalizacion"]),
                    Repeticion = row["Repeticion"].ToString(),
                    HoraRecuerdo = TimeSpan.Parse(row["HoraRecuerdo"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Fotos = row["Fotos"].ToString(),
                    Completado = Convert.ToBoolean(row["Completado"])
                });
            }
            return lista;
        }

        public static List<Tarea> BuscarTareas(string texto)
        {
            List<Tarea> lista = new List<Tarea>();
            string query = @"SELECT t.*, p.NombrePlanta, p.Especie 
                            FROM Tareas t 
                            JOIN Plantas p ON t.PlantaId = p.Id 
                            WHERE p.NombrePlanta LIKE @texto OR 
                                  t.TipoAccion LIKE @texto OR 
                                  t.Ubicacion LIKE @texto
                            ORDER BY t.FechaInicio ASC";
            MySqlParameter[] parameters = { new MySqlParameter("@texto", "%" + texto + "%") };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Tarea
                {
                    Id = Convert.ToInt32(row["Id"]),
                    PlantaId = Convert.ToInt32(row["PlantaId"]),
                    NombrePlanta = row["NombrePlanta"].ToString(),
                    Especie = row["Especie"].ToString(),
                    TipoAccion = row["TipoAccion"].ToString(),
                    Prioridad = row["Prioridad"].ToString(),
                    Ubicacion = row["Ubicacion"].ToString(),
                    FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                    FechaFinalizacion = Convert.ToDateTime(row["FechaFinalizacion"]),
                    Repeticion = row["Repeticion"].ToString(),
                    HoraRecuerdo = TimeSpan.Parse(row["HoraRecuerdo"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Fotos = row["Fotos"].ToString(),
                    Completado = Convert.ToBoolean(row["Completado"])
                });
            }
            return lista;
        }

        public static List<Tarea> ObtenerTareasDeHoy()
        {
            List<Tarea> lista = new List<Tarea>();
            string query = @"SELECT t.*, p.NombrePlanta, p.Especie 
                            FROM Tareas t 
                            JOIN Plantas p ON t.PlantaId = p.Id 
                            WHERE t.FechaInicio = CURDATE() 
                            ORDER BY t.HoraRecuerdo ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Tarea
                {
                    Id = Convert.ToInt32(row["Id"]),
                    PlantaId = Convert.ToInt32(row["PlantaId"]),
                    NombrePlanta = row["NombrePlanta"].ToString(),
                    Especie = row["Especie"].ToString(),
                    TipoAccion = row["TipoAccion"].ToString(),
                    Prioridad = row["Prioridad"].ToString(),
                    Ubicacion = row["Ubicacion"].ToString(),
                    FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                    FechaFinalizacion = Convert.ToDateTime(row["FechaFinalizacion"]),
                    Repeticion = row["Repeticion"].ToString(),
                    HoraRecuerdo = TimeSpan.Parse(row["HoraRecuerdo"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Fotos = row["Fotos"].ToString(),
                    Completado = Convert.ToBoolean(row["Completado"])
                });
            }
            return lista;
        }

        public static bool AgregarTarea(Tarea t)
        {
            try
            {
                int plantaId = PlantaDAL.ObtenerOCrearPlanta(t.NombrePlanta, t.Especie);
                if (plantaId == -1) return false;

                string query = @"INSERT INTO Tareas (PlantaId, TipoAccion, Prioridad, Ubicacion, 
                                FechaInicio, FechaFinalizacion, Repeticion, HoraRecuerdo, Descripcion, Fotos, Completado)
                                VALUES (@plantaId, @accion, @prioridad, @ubicacion, @fechaInicio, @fechaFin,
                                @repeticion, @hora, @descripcion, @fotos, @completado)";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@plantaId", plantaId),
                    new MySqlParameter("@accion", t.TipoAccion),
                    new MySqlParameter("@prioridad", t.Prioridad),
                    new MySqlParameter("@ubicacion", t.Ubicacion),
                    new MySqlParameter("@fechaInicio", t.FechaInicio),
                    new MySqlParameter("@fechaFin", t.FechaFinalizacion),
                    new MySqlParameter("@repeticion", t.Repeticion),
                    new MySqlParameter("@hora", t.HoraRecuerdo.ToString()),
                    new MySqlParameter("@descripcion", string.IsNullOrEmpty(t.Descripcion) ? "" : t.Descripcion),
                    new MySqlParameter("@fotos", string.IsNullOrEmpty(t.Fotos) ? "" : t.Fotos),
                    new MySqlParameter("@completado", t.Completado)
                };

                int resultado = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al agregar tarea: {ex.Message}", "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ActualizarTarea(Tarea t)
        {
            try
            {
                int plantaId = PlantaDAL.ObtenerOCrearPlanta(t.NombrePlanta, t.Especie);
                if (plantaId == -1) return false;

                string query = @"UPDATE Tareas SET 
                                PlantaId = @plantaId,
                                TipoAccion = @accion,
                                Prioridad = @prioridad,
                                Ubicacion = @ubicacion,
                                FechaInicio = @fechaInicio,
                                FechaFinalizacion = @fechaFin,
                                Repeticion = @repeticion,
                                HoraRecuerdo = @hora,
                                Descripcion = @descripcion,
                                Fotos = @fotos,
                                Completado = @completado 
                                WHERE Id = @id";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@id", t.Id),
                    new MySqlParameter("@plantaId", plantaId),
                    new MySqlParameter("@accion", t.TipoAccion),
                    new MySqlParameter("@prioridad", t.Prioridad),
                    new MySqlParameter("@ubicacion", t.Ubicacion),
                    new MySqlParameter("@fechaInicio", t.FechaInicio),
                    new MySqlParameter("@fechaFin", t.FechaFinalizacion),
                    new MySqlParameter("@repeticion", t.Repeticion),
                    new MySqlParameter("@hora", t.HoraRecuerdo.ToString()),
                    new MySqlParameter("@descripcion", string.IsNullOrEmpty(t.Descripcion) ? "" : t.Descripcion),
                    new MySqlParameter("@fotos", string.IsNullOrEmpty(t.Fotos) ? "" : t.Fotos),
                    new MySqlParameter("@completado", t.Completado)
                };

                int resultado = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al actualizar tarea: {ex.Message}", "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool EliminarTarea(int id)
        {
            try
            {
                string query = "DELETE FROM Tareas WHERE Id = @id";
                MySqlParameter[] parameters = { new MySqlParameter("@id", id) };
                int resultado = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al eliminar tarea: {ex.Message}", "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool MarcarCompletada(int id, bool completado)
        {
            try
            {
                string query = "UPDATE Tareas SET Completado = @completado WHERE Id = @id";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@id", id),
                    new MySqlParameter("@completado", completado)
                };
                int resultado = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al marcar completado: {ex.Message}", "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public static int ContarPlantasTotales()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Plantas WHERE Activo = 1";
                object resultado = DatabaseHelper.ExecuteScalar(query);
                return resultado != null ? Convert.ToInt32(resultado) : 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int ContarTareasPendientes()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Tareas WHERE Completado = 0";
                object resultado = DatabaseHelper.ExecuteScalar(query);
                return resultado != null ? Convert.ToInt32(resultado) : 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int ContarTareasPorPrioridad(string prioridad)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Tareas WHERE Prioridad = @prioridad AND Completado = 0";
                MySqlParameter[] parameters = { new MySqlParameter("@prioridad", prioridad) };
                object resultado = DatabaseHelper.ExecuteScalar(query, parameters);
                return resultado != null ? Convert.ToInt32(resultado) : 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int ContarTareasParaHoy()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Tareas WHERE FechaInicio = CURDATE() AND Completado = 0";
                object resultado = DatabaseHelper.ExecuteScalar(query);
                return resultado != null ? Convert.ToInt32(resultado) : 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static string ObtenerEstadisticas()
        {
            try
            {
                int totalPlantas = ContarPlantasTotales();
                int pendientes = ContarTareasPendientes();
                int altas = ContarTareasPorPrioridad("Alta");
                int medias = ContarTareasPorPrioridad("Media");
                int bajas = ContarTareasPorPrioridad("Baja");
                int hoy = ContarTareasParaHoy();
                return $"📊 ESTADÍSTICAS:\n🌱 Plantas totales: {totalPlantas}\n⏰ Tareas pendientes: {pendientes}\n🔴 Prioridad Alta: {altas}\n🟠 Prioridad Media: {medias}\n🟢 Prioridad Baja: {bajas}\n📅 Tareas para hoy: {hoy}";
            }
            catch (Exception ex)
            {
                return $"Error al obtener estadísticas: {ex.Message}";
            }
        }
    }
}