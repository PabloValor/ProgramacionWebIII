using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Repositorios;
using AlquilaCocheras.Negocio.Managers;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class UsuarioService
    {
        #region Miembros

        private readonly UsuariosRepositorio _usuariosRepositorio;

        #endregion

        #region Constructores

        public UsuarioService()
        {
            _usuariosRepositorio = new UsuariosRepositorio();
        }

        #endregion

        #region Métodos Publicos

        public Usuarios ObtenerUsuarioPorEmail(string email)
        {
            var usuario = _usuariosRepositorio.ObtenerUsuarioPorEmail(email);
            return usuario;
        }

        public Usuarios ObtenerUsuarioPorId(int id)
        {
            var usuario = _usuariosRepositorio.ObtenerUsuarioPorId(id);

            return usuario;
        }

        public Usuarios ObtenerUsuarioPorEmailYContrasena(string email, string contrasena)
        {
            var usuario = _usuariosRepositorio.ObtenerUsuarioPorEmailYContrasena(email, contrasena);
            return usuario;
        }

        public void GuardarUsuario(Usuarios usuario)
        {
            _usuariosRepositorio.GuardarUsuario(usuario);
        }

        public Usuarios ObtenerUsuarioLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Data.Constantes.Constantes.USUARIO_LOGUEADO_ID);
            var usuario = _usuariosRepositorio.ObtenerUsuarioLogueado(idUsuario);

            return usuario;
        }

        public void ActualizarUsuario(Usuarios usuario)
        {
            _usuariosRepositorio.ActualizarUsuario(usuario);
        }

        public bool YaExisteEmail(string email)
        {
            var existeMail = _usuariosRepositorio.YaExisteEmail(email);
            return existeMail;
        }

        #endregion
    }
}
