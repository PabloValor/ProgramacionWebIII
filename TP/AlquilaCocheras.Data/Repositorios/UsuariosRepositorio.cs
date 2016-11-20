using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class UsuariosRepositorio
    {
        #region Miembros

        private readonly TP_20162CEntities _db;

        #endregion

        #region Constructores

        public UsuariosRepositorio()
        {
            _db = new TP_20162CEntities();
        }
        #endregion

        #region Métodos Publicos

        public Usuarios ObtenerUsuarioPorId(int id)
        {
            var usuario = _db.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
            return usuario;
        }

        public Usuarios ObtenerUsuarioPorEmail(string email)
        {
            var usuario = _db.Usuarios.FirstOrDefault(u => u.Email == email);
            return usuario;
        }

        public Usuarios ObtenerUsuarioPorEmailYContrasena(string email, string contrasena)
        {
            var usuario = _db.Usuarios.FirstOrDefault(u => u.Email == email && u.Contrasenia == contrasena);
            return usuario;
        }

        public void GuardarUsuario(Usuarios usuario)
        {
            try
            {
                _db.Usuarios.Add(usuario);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error: ocurrió un error al guardar el usuario");
            }
        }

        public Usuarios ObtenerUsuarioLogueado(int idUsuario)
        {
            var usuario = ObtenerUsuarioPorId(idUsuario);
            return usuario;
        }

        public void ActualizarUsuario(Usuarios usuarioActualizado)
        {
            var usuario = _db.Usuarios.FirstOrDefault(u => u.IdUsuario == usuarioActualizado.IdUsuario);
            if (usuario == null) throw new Exception("Error: usuario inexistente");

            try
            {
                _db.Usuarios.AddOrUpdate(usuarioActualizado);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error: no se pudo actualizar el usuario");
            }
        }

        public bool YaExisteEmail(string email)
        {
            var emails = _db.Usuarios.Select(u => u.Email).ToList();
            return emails.Contains(email);
        }
        #endregion
    }
}
