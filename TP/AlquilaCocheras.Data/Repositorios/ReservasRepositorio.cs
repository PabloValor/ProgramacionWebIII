using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class ReservasRepositorio
    {

        #region Miembros

        private readonly TP_20162CEntities _db;

        #endregion

        #region Constructores

        public ReservasRepositorio()
        {
            _db = new TP_20162CEntities();
        }

        #endregion

        #region Métodos Publicos

        public List<Reservas> Obtener()
        {
            var reservas = _db.Reservas.ToList();
            return reservas;
        }

        public void Guardar(Reservas reserva)
        {
            try
            {
                _db.Reservas.Add(reserva);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error: No se pudo generar la reserva. Intente de nuevo");
            }
        }

        public void PuntuarReserva(int idReserva, int puntuacion)
        {
            try
            {
                var reserva = _db.Reservas.FirstOrDefault(r => r.IdReserva == idReserva);
                reserva.Puntuacion = (short)puntuacion;

                _db.Reservas.AddOrUpdate(reserva);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error: No se pudo puntuar la reserva");
            }
        }

        public List<Reservas> ObtenerReservas(int idPropietario)
        {
            var listado = (from propietario in _db.Usuarios
                           join cochera in _db.Cocheras on propietario.IdUsuario equals cochera.IdPropietario
                           where propietario.IdUsuario == idPropietario
                           join reserva in _db.Reservas on cochera.IdCochera equals reserva.IdCochera
                           select reserva).ToList();

            return listado.OrderBy(x => x.FechaFin).ToList();
        }

        public List<Reservas> ObtenerReservasPorFechas(int idPropietario, DateTime fechaInicio, DateTime fechaFin)
        {
            var listado = (from propietario in _db.Usuarios
                           join cochera in _db.Cocheras on propietario.IdUsuario equals cochera.IdPropietario
                           where propietario.IdUsuario == idPropietario 
                           join reserva in _db.Reservas on cochera.IdCochera equals reserva.IdCochera
                           where reserva.FechaInicio.CompareTo(fechaInicio) >= 0 && reserva.FechaFin.CompareTo(fechaFin) <= 0
                           select reserva).ToList();

            return listado.OrderBy(x => x.FechaFin).ToList();
        }

        #endregion
    }
}
