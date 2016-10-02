using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlquilaCocheras.Data.Entidades;

namespace AlquilaCocheras.Data.Repositorios
{
    class ReservasRepositorio
    {
        #region Métodos Publicos

        public List<Reserva> ObtenerTodas()
        {
            return new List<Reserva>();
        }

        public List<Reserva> ObtenerReservas(string ubicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            var reservas = new List<Reserva>
            {
                new Reserva
                {
                    
                }
            };
            return reservas;
        }
        #endregion
    }
}
