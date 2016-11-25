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

        public void GenerarReserva(int idCliente, DateTime fechaInicio, DateTime fechaFin, int idCochera)
        {
            var cochera = _cocherasServicio.ObtenerCocheraPorId(idCochera);

            var reserva = new Reservas
            {
                IdCliente = idCliente,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                CantidadHoras = Convert.ToDecimal((fechaFin - fechaInicio).TotalHours),
                IdCochera = idCochera,
                FechaCarga = DateTime.Now,
                HoraInicio = string.Format("{0}:{1}", fechaInicio.Hour, fechaInicio.Minute),
                HoraFin = string.Format("{0}:{1}", fechaFin.Hour, fechaFin.Minute),
                Precio = cochera.Precio * Convert.ToDecimal((fechaFin - fechaInicio).TotalHours)
            };

            _reservasRepositorio.Guardar(reserva);
        }

        public void PuntuarReserva(int idReserva, int puntuacion)
        {
            _reservasRepositorio.PuntuarReserva(idReserva, puntuacion);
        }

        public List<Reservas> ObtenerReservas(int idPropietario)
        {
            return _reservasRepositorio.ObtenerReservas(idPropietario);
        }

        public List<Reservas> ObtenerReservasPorFechas(int idPropietario, DateTime fechaInicio, DateTime fechaFin)
        {
            return _reservasRepositorio.ObtenerReservasPorFechas(idPropietario, fechaInicio, fechaFin);
        }

        #endregion
    }
}
