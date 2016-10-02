using System;
using AlquilaCocheras.Data.Enums;

namespace AlquilaCocheras.Data.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public PerfilUsuario Perfil { get; set; }
    }
}
