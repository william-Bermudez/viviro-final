using System;

namespace viviro_final
{
    public class Planta
    {
        public int Id { get; set; }
        public string NombrePlanta { get; set; }
        public string Especie { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        public Planta()
        {
            Id = 0;
            NombrePlanta = "";
            Especie = "";
            FechaRegistro = DateTime.Now;
            Activo = true;
        }

        public string NombreCompleto
        {
            get
            {
                if (string.IsNullOrEmpty(Especie))
                    return NombrePlanta;
                else
                    return $"{NombrePlanta} ({Especie})";
            }
        }
    }
}