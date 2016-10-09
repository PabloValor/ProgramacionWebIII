using System;

namespace AlquilaCocheras.Data.Mapeos
{
    public class ClienteReservaMap
    {
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Horario { get; set; }
        public double PrecioFinal { get; set; }
        public double Puntuacion { get; set; }
        public string EsReservaYaUtilizada { get; set; }
    }
}
