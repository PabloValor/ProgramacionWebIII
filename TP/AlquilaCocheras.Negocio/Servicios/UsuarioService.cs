using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Repositorios;

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

        #endregion
    }
}
