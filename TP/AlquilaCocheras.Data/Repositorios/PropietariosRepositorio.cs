using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class PropietariosRepositorio
    {
        #region Miembros

        private readonly EstacionaloEntities _db;

        #endregion

        #region Constructores

        public PropietariosRepositorio()
        {
            _db = new EstacionaloEntities();
        }
        #endregion

        #region Métodos Publicos

        public Propietario ObtenerPropietarioPorIdUsuario(int idUsuario)
        {

            var query = (from p in _db.Propietario
                         join u in _db.Usuario on p.IdUsuario equals u.Id
                         join tp in _db.TipoPerfilUsuario on u.IdTipoPerfilUsuario equals tp.Id
                         where u.Id == idUsuario && tp.Id == (int)Enums.TipoPerfilUsuario.Cliente
                         select new { p }).First().p;

            return query;
        }

        public void ActualizarPropietario(Propietario propietarioActualizado)
        {
            var propietario = _db.Propietario.FirstOrDefault(u => u.Id == propietarioActualizado.Id);
            if (propietario == null) throw new Exception("Error: Usuario inexistente");

            _db.Propietario.AddOrUpdate(propietarioActualizado);
            _db.SaveChanges();
        }

        #endregion
    }
}
