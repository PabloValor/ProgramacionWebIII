using System;

namespace AlquilaCocheras.Data.Mapeos
{
    public class ClienteReservaMap
    {
        public int IdReserva { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string HorarioInicio { get; set; }
        public string HorarioFin { get; set; }
        public decimal PrecioFinal { get; set; }
        public double Puntuacion { get; set; }
        public bool EsReservaYaUtilizada { get; set; }
    }
}
