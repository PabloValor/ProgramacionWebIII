using AlquilaCocheras.Data.Enums;

namespace AlquilaCocheras.Data.Entidades
{
    public class Cochera
    {
        public int Id { get; set; }
        public Propietario Propietario { get; set; } // borrar
        public int IdPropietario { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int SuperficieM2 { get; set; }
        public string Imagen { get; set; }
        public double PrecioPorHora { get; set; }
        public Puntaje Puntaje { get; set; } // borrar
        public int IdPuntaje { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
        public bool Disponible { get; set; }
    }
}
