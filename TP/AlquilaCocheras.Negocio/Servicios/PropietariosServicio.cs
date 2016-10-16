using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Repositorios;
using AlquilaCocheras.Negocio.Managers;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class PropietariosServicio
    {
        #region Miembros

        private readonly UsuariosRepositorio _usuariosRepositorio;

        #endregion

        #region Constructores

        public PropietariosServicio()
        {
            _usuariosRepositorio = new UsuariosRepositorio();
        }

        #endregion

        #region Métodos Publicos

        public Propietario ObtenerPropietarioLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Data.Constantes.Constantes.USUARIO_LOGUEADO_ID);
            var propietario = _usuariosRepositorio.ObtenerPropietarioPorId(idUsuario);
            return propietario;
        }

        public void ActualizarPropietario(Propietario propietario)
        {
            _usuariosRepositorio.ActualizarUsuario(propietario);
        }

        #endregion

    }
}
