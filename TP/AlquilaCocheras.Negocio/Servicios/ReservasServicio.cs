using System;
using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Repositorios;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class ReservasServicio
    {
        #region Miembros

        private readonly ReservasRepositorio _reservasRepositorio;
        private readonly ClientesServicio _clientesServicio;

        #endregion

        #region Constructores

        public ReservasServicio()
        {
            _reservasRepositorio = new ReservasRepositorio();
            _clientesServicio = new ClientesServicio();
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

        public void GenerarReserva(Cliente cliente, Cochera cochera, DateTime fechaInicio, DateTime fechaFin)
        {
            cochera.Disponible = false;

            var reserva = new Reserva
            {
                Cliente = cliente,
                Cochera = cochera,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };

                _reservasRepositorio.Guardar(reserva);
                _clientesServicio.AgregarReserva(cliente, reserva);
        }

        #endregion
    }
}
