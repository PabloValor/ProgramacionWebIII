using System.Collections.Generic;
using System.Linq;
using AlquilaCocheras.Data.Entidades;
using AlquilaCocheras.Data.Enums;

namespace AlquilaCocheras.Data.Repositorios
{
    public class UsuariosRepositorio
    {
        #region Miembros

        private readonly List<Usuario> _usuarios;
        private readonly List<Cliente> _clientes;
        private readonly List<Propietario> _propietarios;

        #endregion

        #region Constructores

        public UsuariosRepositorio()
        {
            _usuarios = GenerarUsuariosMock();
            _clientes = GenerarClientesMock();
            _propietarios = GenerarPropietariosMock();
        }
        #endregion

        #region Métodos Publicos

        public Usuario ObtenerUsuarioPorId(int id)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
            return usuario;
        }

        public Usuario ObtenerUsuarioPorEmail(string email)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Email == email);
            return usuario;
        }

        public Cliente ObtenerClientePorId(int id)
        {
            var cliente = _clientes.FirstOrDefault(u => u.Id == id && u.Perfil == TipoPerfilUsuario.Cliente);
            return cliente;
        }

        public Propietario ObtenerPropietarioPorId(int id)
        {
            var propietarios = _propietarios.FirstOrDefault(u => u.Id == id && u.Perfil == TipoPerfilUsuario.Propietario);
            return propietarios;
        }

        #endregion

        #region Métodos Privados

        private List<Usuario> GenerarUsuariosMock()
        {
            var cliente = new Cliente()
            {
                Nombre = "José",
                Apellido = "Perez",
                Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
                Email = "cliente@gmail.com",
                Password = "Password1",
                Id = 1,
                Perfil = TipoPerfilUsuario.Cliente
            };

            var propietario = new Propietario()
            {
                Nombre = "Carlos",
                Apellido = "Lopez",
                Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
                Email = "propietario@gmail.com",
                Password = "Password1",
                Id = 2,
                Perfil = TipoPerfilUsuario.Propietario
            };

            return new List<Usuario>
            {
                cliente, propietario
            };
        }

        private List<Cliente> GenerarClientesMock()
        {
            var cliente = new Cliente()
            {
                Nombre = "José",
                Apellido = "Perez",
                Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
                Email = "cliente@gmail.com",
                Password = "Password1",
                Id = 1,
                Perfil = TipoPerfilUsuario.Cliente,
                Reservas = new List<Reserva>()
            };

            return new List<Cliente>
            {
                cliente
            };
        }

        private List<Propietario> GenerarPropietariosMock()
        {
            var propietario = new Propietario()
            {
                Nombre = "Carlos",
                Apellido = "Lopez",
                Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
                Email = "propietario@gmail.com",
                Password = "Password1",
                Id = 2,
                Perfil = TipoPerfilUsuario.Propietario,
                Cocheras = new List<Cochera>()
            };

            return new List<Propietario>
            {
               propietario
            };            
        } 
        #endregion
    }
}
