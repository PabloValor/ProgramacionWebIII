using System;

namespace AlquilaCocheras.Data.Entidades
{
    public class Reserva
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public Cochera Cochera { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantidadHoras { get; set; }
    }
}
