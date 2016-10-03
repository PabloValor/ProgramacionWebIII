using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Repositorios;

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

        #endregion
    }
}
