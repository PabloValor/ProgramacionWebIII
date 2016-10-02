using System;
using AlquilaCocheras.Data.Enums;

namespace AlquilaCocheras.Data.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public TipoPerfilUsuario Perfil { get; set; }
    }
}
