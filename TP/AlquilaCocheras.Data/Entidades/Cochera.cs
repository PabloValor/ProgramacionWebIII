using System;

namespace AlquilaCocheras.Data.Entidades
{
    public class Cochera
    {
        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public int superficieM2 { get; set; }
        public int tipo { get; set; }
        public decimal PrecioPorHora { get; set; }
        public string Foto { get; set; }

    }
}
