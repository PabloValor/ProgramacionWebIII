using AlquilaCocheras.Data;
using AlquilaCocheras.Data.Repositorios;
using AlquilaCocheras.Negocio.Managers;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class ClientesServicio
    {
        #region Miembros

        private readonly ClientesRepositorio _clientesRepositorio;

        #endregion

        #region Constructores

        public ClientesServicio()
        {
            _clientesRepositorio = new ClientesRepositorio();
        }

        #endregion

        #region Métodos Publicos

        public  Usuarios ObtenerClientePorId(int id)
        {
            var cliente = _clientesRepositorio.ObtenerClientePorId(id);
            return cliente;
        }

        public Usuarios ObtenerClienteLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Data.Constantes.Constantes.USUARIO_LOGUEADO_ID);
            var cliente = _clientesRepositorio.ObtenerClientePorId(idUsuario);
            return cliente;
        }

        #endregion
    }
}
