using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilaCocheras.Data.Entidades
{
    class Usuario
    {
        public int id_usuario { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public int perfil { get; set; }
    }
}
