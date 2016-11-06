using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class PropietariosRepositorio
    {
        #region Miembros

        private readonly TP_20162CEntities _db;

        #endregion

        #region Constructores

        public PropietariosRepositorio()
        {
            _db = new TP_20162CEntities();
        }
        #endregion

        #region Métodos Publicos

        public Usuarios ObtenerPropietarioPorId(int id)
        {

            var propietario =
                _db.Usuarios.FirstOrDefault(
                    p => p.IdUsuario == id && p.Perfil == (int) Enums.TipoPerfilUsuario.Propietario);

            return propietario;
        }

        public void ActualizarPropietario(Usuarios propietarioActualizado)
        {
            try
            {
                _db.Usuarios.AddOrUpdate(propietarioActualizado);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Error: no se pudo actualizar el usuario");
            }
        }

        #endregion
    }
}
