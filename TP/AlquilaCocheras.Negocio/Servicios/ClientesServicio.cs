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

        public Cliente ObtenerClientePorId(int id)
        {
            var cliente = _clientesRepositorio.ObtenerClientePorId(id);
            return cliente;
        }

        public void AgregarReserva(Cliente cliente, Reserva reserva)
        {
            //cliente.Reservas.Add(reserva);
        }

        public Cliente ObtenerClienteLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Data.Constantes.Constantes.USUARIO_LOGUEADO_ID);
            var cliente = _clientesRepositorio.ObtenerClientePorId(idUsuario);
            return cliente;
        }

        #endregion
    }
}
