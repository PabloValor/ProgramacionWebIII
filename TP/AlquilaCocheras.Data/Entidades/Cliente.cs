using System.Collections.Generic;

namespace AlquilaCocheras.Data.Entidades
{
    public class Cliente : Entidades.Usuario
    {
        public List<Reserva> Reservas { get; set; }
    }
}
