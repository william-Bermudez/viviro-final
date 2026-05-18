using System;

namespace viviro_final
{
    public class Tarea
    {
        public int Id { get; set; }
        public int PlantaId { get; set; }
        public string NombrePlanta { get; set; }
        public string Especie { get; set; }
        public string TipoAccion { get; set; }
        public string Prioridad { get; set; }
        public string Ubicacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public string Repeticion { get; set; }
        public TimeSpan HoraRecuerdo { get; set; }
        public string Descripcion { get; set; }
        public string Fotos { get; set; }
        public bool Completado { get; set; }

        public Tarea()
        {
            Id = 0;
            PlantaId = 0;
            NombrePlanta = "";
            Especie = "";
            TipoAccion = "";
            Prioridad = "";
            Ubicacion = "";
            FechaInicio = DateTime.Now;
            FechaFinalizacion = DateTime.Now;
            Repeticion = "No repetir";
            HoraRecuerdo = TimeSpan.FromHours(8);
            Descripcion = "";
            Fotos = "";
            Completado = false;
        }

        public Tarea(string nombrePlanta, string tipoAccion, string prioridad, string ubicacion,
                     DateTime fechaInicio, DateTime fechaFin, TimeSpan horaRecuerdo)
        {
            NombrePlanta = nombrePlanta;
            TipoAccion = tipoAccion;
            Prioridad = prioridad;
            Ubicacion = ubicacion;
            FechaInicio = fechaInicio;
            FechaFinalizacion = fechaFin;
            HoraRecuerdo = horaRecuerdo;
            Especie = "";
            Repeticion = "No repetir";
            Descripcion = "";
            Fotos = "";
            Completado = false;
            PlantaId = 0;
        }

        public override string ToString()
        {
            return $"[{Id}] {TipoAccion} de {NombrePlanta} - {FechaInicio:dd/MM/yyyy} a las {HoraRecuerdo:hh\\:mm}";
        }

        public bool EstaVencida()
        {
            return FechaInicio < DateTime.Now && !Completado;
        }

        public bool EsParaHoy()
        {
            return FechaInicio.Date == DateTime.Now.Date && !Completado;
        }

        public System.Drawing.Color GetColorPrioridad()
        {
            switch (Prioridad.ToLower())
            {
                case "alta":
                    return System.Drawing.Color.Red;
                case "media":
                    return System.Drawing.Color.Orange;
                case "baja":
                    return System.Drawing.Color.Green;
                default:
                    return System.Drawing.Color.Black;
            }
        }
    }
}