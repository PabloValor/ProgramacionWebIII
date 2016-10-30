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

        public Propietario ObtenerPropietarioLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Data.Constantes.Constantes.USUARIO_LOGUEADO_ID);
            var propietario = _propietariosRepositorio.ObtenerPropietarioPorIdUsuario(idUsuario);
            return propietario;
        }

        public void ActualizarPropietario(Propietario propietario)
        {
            _propietariosRepositorio.ActualizarPropietario(propietario);
        }

        #endregion

    }
}
