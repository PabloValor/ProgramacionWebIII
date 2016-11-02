using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Repositorios;
using AlquilaCocheras.Negocio.Managers;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class UsuarioService
    {
        #region Miembros

        private readonly UsuariosRepositorio _usuariosRepositorio;
        private readonly ClientesRepositorio _clientesRepositorio;

        #endregion

        #region Constructores

        public UsuarioService()
        {
            _usuariosRepositorio = new UsuariosRepositorio();
            _clientesRepositorio = new ClientesRepositorio();
        }

        #endregion

        #region Métodos Publicos

        public Usuario ObtenerUsuarioPorEmail(string email)
        {
            var usuario = _usuariosRepositorio.ObtenerUsuarioPorEmail(email);
            return usuario;
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            var usuario = _usuariosRepositorio.ObtenerUsuarioPorId(id);

            return usuario;
        }

        public Usuario ObtenerUsuarioPorEmailYContrasena(string email, string contrasena)
        {
            var usuario = _usuariosRepositorio.ObtenerUsuarioPorEmailYContrasena(email, contrasena);
            return usuario;
        }

        public void GuardarUsuario(Usuario usuario)
        {
            _usuariosRepositorio.GuardarUsuario(usuario);
        }

        public Usuario ObtenerUsuarioLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Data.Constantes.Constantes.USUARIO_LOGUEADO_ID);
            var usuario = _usuariosRepositorio.ObtenerUsuarioLogueado(idUsuario);

            return usuario;
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            _usuariosRepositorio.ActualizarUsuario(usuario);
        }

        #endregion
    }
}
