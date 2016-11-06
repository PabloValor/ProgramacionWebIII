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

        //public void ActualizarDisponibilidad(int idCochera, bool disponibilidad)
        //{
        //    try
        //    {
        //        var cochera = _db.Cochera.FirstOrDefault(c => c.Id == idCochera);

        //        if (cochera == null) throw new Exception("Error: No se pudo actualizar la disponibilidad, la cochera no existe");

        //        cochera.Disponible = disponibilidad;

        //        _db.Cochera.AddOrUpdate(cochera);
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("Error: no se pudo actualizar la disponibilidad de la cochera");
        //    }
        //}

        #endregion

        #region Métodos Privados
        #endregion
    }
}
