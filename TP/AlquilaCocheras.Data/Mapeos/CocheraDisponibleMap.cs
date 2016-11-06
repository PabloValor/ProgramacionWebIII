namespace AlquilaCocheras.Data.Mapeos
{
    public class CocheraDisponibleMap
    {
        public int Id { get; set; }
        public string NombrePropietario { get; set; }
        public string ApellidoPropietario { get; set; }
        public decimal PrecioPorHora { get; set; }
        public string Imagen { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public decimal PuntajePromedioCochera { get; set; }
        public string Ubicacion { get; set; }
    }
}
