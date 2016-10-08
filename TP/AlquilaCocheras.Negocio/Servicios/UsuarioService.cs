using AlquilaCocheras.Data.Entidades;
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

        public Cliente ObtenerClientePorId(int id)
        {
            var cliente = _usuariosRepositorio.ObtenerClientePorId(id);
            return cliente;
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
