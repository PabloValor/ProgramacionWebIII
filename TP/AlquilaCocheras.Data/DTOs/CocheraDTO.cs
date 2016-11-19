namespace AlquilaCocheras.Data.DTOs
{
    public class CocheraDTO
    {
        public bool NoDisponible { get; set; }
        public int IdCochera { get; set; }
        public int IdPropietario { get; set; }
        public string Ubicacion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string Descripcion { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public int MetrosCuadrados { get; set; }
        public short TipoVehiculo { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public string NombrePropietario { get; set; }
        public string ApellidoPropietario { get; set; }
        public decimal PrecioPorHora { get; set; }
        public double PuntajePromedioCochera { get; set; }
    }
}
