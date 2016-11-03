using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AlquilaCocheras.Data.Repositorios
{
    public class UsuariosRepositorio
    {
        #region Miembros
        private readonly EstacionaloEntities _db;
        #endregion

        #region Constructores

        public UsuariosRepositorio()
        {
            _db = new EstacionaloEntities();
        }
        #endregion

        #region Métodos Publicos

        public Usuario ObtenerUsuarioPorId(int id)
        {
            var usuario = _db.Usuario.FirstOrDefault(u => u.Id == id);
            return usuario;
        }

        public Usuario ObtenerUsuarioPorEmail(string email)
        {
            var usuario = _db.Usuario.FirstOrDefault(u => u.Email == email);
            return usuario;
        }

        public Usuario ObtenerUsuarioPorEmailYContrasena(string email, string contrasena)
        {
            var usuario = _db.Usuario.FirstOrDefault(u => u.Email == email && u.Password == contrasena);
            return usuario;
        }

        public void GuardarUsuario(Usuario usuario)
        {
            try
            {
                _db.Usuario.Add(usuario);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error: ocurrió un error al guardar el usuario");
            }
        }

        public Usuario ObtenerUsuarioLogueado(int idUsuario)
        {
            var usuario = ObtenerUsuarioPorId(idUsuario);
            return usuario;
        }

        public void ActualizarUsuario(Usuario usuarioActualizado)
        {
            var usuario = _db.Usuario.FirstOrDefault(u => u.Id == usuarioActualizado.Id);
            if (usuario == null) throw new Exception("Error: usuario inexistente");

            try
            {
                _db.Usuario.AddOrUpdate(usuarioActualizado);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error: no se pudo actualizar el usuario");
            }
        }

        public bool YaExisteEmail(string email)
        {
            var emails = _db.Usuario.Select(u => u.Email).ToList();
            return emails.Contains(email);
        }
        #endregion

        #region Métodos Privados

        //private List<Entidades.Usuario> GenerarUsuariosMock()
        //{
        //    var cliente = new Cliente()
        //    {
        //        Nombre = "José",
        //        Apellido = "Perez",
        //        Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
        //        Email = "cliente@gmail.com",
        //        Password = "Password1",
        //        Id = 1,
        //        Perfil = TipoPerfilUsuario.Cliente
        //    };

        //    var propietario = new Propietario()
        //    {
        //        Nombre = "Carlos",
        //        Apellido = "Lopez",
        //        Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
        //        Email = "propietario@gmail.com",
        //        Password = "Password1",
        //        Id = 2,
        //        Perfil = TipoPerfilUsuario.Propietario
        //    };

        //    return new List<Entidades.Usuario>
        //    {
        //        cliente, propietario
        //    };
        //}

        //private List<Cliente> GenerarClientesMock()
        //{
        //    var clientes = new List<Cliente>();

        //    var cliente = new Cliente()
        //    {
        //        Nombre = "José",
        //        Apellido = "Perez",
        //        Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
        //        Email = "cliente@gmail.com",
        //        Password = "Password1",
        //        Id = 1,
        //        Perfil = TipoPerfilUsuario.Cliente,
        //        Reservas = new List<Reserva>
        //        {
        //            new Reserva
        //            {
        //                CantidadHoras = 155,
        //                FechaInicio = new DateTime(),
        //                FechaFin = new DateTime().AddDays(1),
        //                Cochera = new Cochera
        //                {
        //                    PrecioPorHora = 10
        //                }
        //            },
        //            new Reserva
        //            {
        //                CantidadHoras = 155,
        //                FechaInicio = new DateTime(),
        //                FechaFin = new DateTime().AddDays(1),
        //                Cochera = new Cochera
        //                {
        //                    PrecioPorHora = 10
        //                }
        //            },
        //            new Reserva
        //            {
        //                CantidadHoras = 155,
        //                FechaInicio = new DateTime(),
        //                FechaFin = new DateTime().AddDays(1),
        //                Cochera = new Cochera
        //                {
        //                    PrecioPorHora = 10
        //                }
        //            },
        //            new Reserva
        //            {
        //                CantidadHoras = 155,
        //                FechaInicio = new DateTime(),
        //                FechaFin = new DateTime().AddDays(1),
        //                Cochera = new Cochera
        //                {
        //                    PrecioPorHora = 10
        //                }
        //            }
        //        }
        //    };

        //    for (int i = 0; i < 5; i++)
        //    {
        //        clientes.Add(cliente);    
        //    }

        //    return clientes;
        //}

        //private List<Propietario> GenerarPropietariosMock()
        //{
        //    var propietario = new Propietario()
        //    {
        //        Nombre = "Carlos",
        //        Apellido = "Lopez",
        //        Avatar = "https://image.freepik.com/iconos-gratis/user-avatar-fotografia-principal_318-85015.jpg",
        //        Email = "propietario@gmail.com",
        //        Password = "Password1",
        //        Id = 2,
        //        Perfil = TipoPerfilUsuario.Propietario,
        //        Cocheras = new List<Cochera>()
        //    };

        //    return new List<Propietario>
        //    {
        //       propietario
        //    };            
        //} 
        
        #endregion
    }
}
