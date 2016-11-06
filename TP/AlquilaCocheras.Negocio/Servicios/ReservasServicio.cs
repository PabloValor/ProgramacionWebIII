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

        public List<Reservas> ObtenerTodas()
        {
            var reservas = _reservasRepositorio.Obtener();

            return reservas;
        }

        public Reservas ObtenerReservaPorId(int id)
        {
            var reserva = ObtenerTodas().FirstOrDefault(r => r.IdReserva == id);

            return reserva;
        }

        public void GenerarReserva(int idCliente, DateTime fechaInicio, DateTime fechaFin, int cantidadHoras, int idCochera)
        {
            var reserva = new Reservas
            {
                IdCliente = idCliente,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                CantidadHoras = cantidadHoras,
                IdCochera = idCochera
            };

            _reservasRepositorio.Guardar(reserva);
            //_cocherasServicio.ActualizarDisponibilidad(idCochera, false);
        }

        #endregion
    }
}
