using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class CocherasRepositorio
    {
        #region Miembros

        private readonly TP_20162CEntities _db;

        #endregion

        #region Constructores

        public CocherasRepositorio()
        {
            _db = new TP_20162CEntities();
        }

        #endregion

        #region Métodos Publicos

        public List<Cocheras> Obtener()
        {
            var cocheras = _db.Cocheras.ToList();
            return cocheras;
        }

        public List<Cocheras> Obtener(string txtUbicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            var cocheras = _db.Cocheras
                .Where(c => c.Ubicacion.ToLower().Contains(txtUbicacion) && fechaInicio.CompareTo(c.FechaInicio) >= 0 && fechaFin.CompareTo(c.FechaFin) <= 0).ToList();
            return cocheras;
        }

        public Cocheras ObtenerCocheraPorId(int id)
        {
            var cochera = _db.Cocheras.FirstOrDefault(c => c.IdCochera == id);
            return cochera;
        }

        public void Guardar(Cocheras cochera)
        {
            try
            {
                _db.Cocheras.Add(cochera);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Error: no se ha podido guardar la cochera");
            }
        }

        #endregion

        #region Métodos Privados
        #endregion
    }
}
