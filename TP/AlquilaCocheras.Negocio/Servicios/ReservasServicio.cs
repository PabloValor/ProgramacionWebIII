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

        public List<Reservas> ObtenerReservasDeCocheraPorIdCochera(int idCochera)
        {
            var reservas = ObtenerTodas().Where(r => r.IdCochera == idCochera).ToList();

            return reservas;
        }

        public void GenerarReserva(Reservas reserva)
        {
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

        public bool EsReservaDisponible(Reservas reservaPendiente)
        {
            var cocheraDisponible = _cocherasServicio.ObtenerCocheraPorId(reservaPendiente.IdCochera);

            // Se valida que la cochera este en el rango de horarios indicado, ya que el buscador de cocheras no contempla la hora
            if (cocheraDisponible.FechaInicio.CompareTo(reservaPendiente.FechaInicio) <= 0 &&
                cocheraDisponible.FechaFin.CompareTo(reservaPendiente.FechaFin) >= 0)
            {
                // se valida que la cochera no esté reservada en el rango solicitado
                var reservasDisponible = !ObtenerReservasDeCocheraPorIdCochera(reservaPendiente.IdCochera)
                .Any(x => x.FechaInicio.CompareTo(reservaPendiente.FechaInicio) >= 0 && x.FechaFin.CompareTo(reservaPendiente.FechaFin) <= 0);

                return reservasDisponible;
            }
            return false;
        }

        public double ObtenerPuntuacionPromedio(int idCochera)
        {
            return _reservasRepositorio.ObtenerPuntuacionPromedio(idCochera);
        }

        #endregion
    }
}
