using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilaCocheras.Data.Entidades
{
    class Usuario
    {
        public int Id_Usuario { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public int Perfil { get; set; }
    }
}
