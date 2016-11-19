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

        //public List<Reservas> Obtener(string ubicacion, DateTime fechaInicio, DateTime fechaFin)
        //{
        //    var reservas = _db.Reservas.Where(r => r.Cocheras.Ubicacion == ubicacion && reser)

        //    return reservas;
        //}

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

        #endregion

        #region Métodos Privados
        #endregion
    }
}
