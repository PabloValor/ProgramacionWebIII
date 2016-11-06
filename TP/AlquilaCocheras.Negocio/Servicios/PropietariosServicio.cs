using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Repositorios;
using AlquilaCocheras.Negocio.Managers;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class PropietariosServicio
    {
        #region Miembros

        private readonly PropietariosRepositorio _propietariosRepositorio;

        #endregion

        #region Constructores

        public PropietariosServicio()
        {
            _propietariosRepositorio = new PropietariosRepositorio();
        }

        #endregion

        #region Métodos Publicos

        public Usuarios ObtenerPropietarioLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Data.Constantes.Constantes.USUARIO_LOGUEADO_ID);
            var propietario = _propietariosRepositorio.ObtenerPropietarioPorId(idUsuario);
            return propietario;
        }

        public void ActualizarPropietario(Usuarios propietario)
        {
            _propietariosRepositorio.ActualizarPropietario(propietario);
        }

        #endregion

    }
}
