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
            _usuarios = new List<Usuario>();
            _clientes = new List<Cliente>();
            _propietarios = new List<Propietario>();
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
    }
}
