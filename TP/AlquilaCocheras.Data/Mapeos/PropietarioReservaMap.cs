namespace AlquilaCocheras.Data.Mapeos
{
    public class PropietarioReservaMap
    {
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public decimal PrecioCobrado { get; set; }
        public double Puntuacion { get; set; }
        public bool EsReservaYaUtilizada { get; set; }
        public string Ubicacion { get; set; }
        public int CantidadHoras { get; set; }
    }
}
