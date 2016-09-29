using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilaCocheras.Data.Entidades
{
    class Cochera
    {
        public int id_cochera { get; set; }
        public int ubicacion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public DateTime horario_inicio { get; set; }
        public DateTime horario_fin { get; set; }
        public String descripcion { get; set; }
        public int latitud { get; set; }
        public int longitud { get; set; }
        public int superficie_m2 { get; set; }
        public int tipo { get; set; }
        public int precio_por_hora { get; set; }
        public int foto { get; set; }

    }
}
