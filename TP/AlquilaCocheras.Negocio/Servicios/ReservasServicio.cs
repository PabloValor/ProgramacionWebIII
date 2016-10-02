using System;
using System.Collections.Generic;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Repositorios;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class ReservasServicio
    {
        #region Miembros

        ReservasRepositorio _reservasRepositorio;

        #endregion

        #region Constructores

        public ReservasServicio()
        {
            _reservasRepositorio = new ReservasRepositorio();
        }

        #endregion

        #region Métodos Publicos

        public List<Reserva> ObtenerTodas()
        {
            var reservas = _reservasRepositorio.Obtener();

            return reservas;
        }

        public List<Reserva> ObtenerReservas(string ubicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            var reservas = _reservasRepositorio.Obtener(ubicacion, fechaInicio, fechaFin);

            return reservas;
        }

        #endregion
    }
}
