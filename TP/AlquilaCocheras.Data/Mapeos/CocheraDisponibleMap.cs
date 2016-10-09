namespace AlquilaCocheras.Data.Mapeos
{
    public class CocheraDisponibleMap
    {
        public int Id { get; set; }
        public string NombrePropietario { get; set; }
        public string ApellidoPropietario { get; set; }
        public double PrecioPorHora { get; set; }
        public string Imagen { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public double PuntajePromedioCochera { get; set; }
    }
}
