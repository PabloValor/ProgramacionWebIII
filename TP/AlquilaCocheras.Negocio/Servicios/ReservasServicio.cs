using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Repositorios;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class ReservasServicio
    {
        #region Miembros

        private readonly ReservasRepositorio _reservasRepositorio;
        private readonly CocherasServicio _cocherasServicio;

        #endregion

        #region Constructores

        public ReservasServicio()
        {
            _reservasRepositorio = new ReservasRepositorio();
            _cocherasServicio = new CocherasServicio();
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

        public Reserva ObtenerReservaPorId(int id)
        {
            var reserva = ObtenerTodas().FirstOrDefault(r => r.Id == id);

            return reserva;
        }

        public void GenerarReserva(int idCliente, DateTime fechaInicio, DateTime fechaFin, int cantidadHoras, int idCochera)
        {
            var reserva = new Reserva
            {
                IdCliente = idCliente,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                CantidadHoras = cantidadHoras,
                IdCochera = idCochera
            };

            _reservasRepositorio.Guardar(reserva);
            _cocherasServicio.ActualizarDisponibilidad(idCochera, false);
        }

        #endregion
    }
}
