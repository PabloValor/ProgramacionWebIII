using System.Collections.Generic;

namespace AlquilaCocheras.Data.Entidades
{
    public class Cliente : Usuario
    {
        public List<Reserva> Reservas { get; set; }
    }
}
