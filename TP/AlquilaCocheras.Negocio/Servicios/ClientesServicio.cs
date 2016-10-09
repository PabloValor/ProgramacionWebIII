using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Repositorios;
using AlquilaCocheras.Negocio.Managers;

namespace AlquilaCocheras.Negocio.Servicios
{
    public class ClientesServicio
    {
        #region Miembros

        private readonly UsuariosRepositorio _usuariosRepositorio;

        #endregion

        #region Constructores

        public ClientesServicio()
        {
            _usuariosRepositorio = new UsuariosRepositorio();
        }

        #endregion

        #region Métodos Publicos

        public Cliente ObtenerClientePorId(int id)
        {
            var cliente = _usuariosRepositorio.ObtenerClientePorId(id);
            return cliente;
        }

        public void AgregarReserva(Cliente cliente, Reserva reserva)
        {
            cliente.Reservas.Add(reserva);
        }

        public Cliente ObtenerClienteLogueado()
        {
            var idUsuario = VariblesSesionManager.Obtener<int>(Data.Constantes.Constantes.USUARIO_LOGUEADO_ID);
            var cliente = _usuariosRepositorio.ObtenerClientePorId(idUsuario);
            return cliente;
        }

        #endregion
    }
}
