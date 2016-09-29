using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilaCocheras.Data.Entidades
{
    class Reserva
    {
        public int id_reserva { get; set; }
        public int id_cliente { get; set; }
        public int id_cochera { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public DateTime horario_inicio { get; set; }
        public DateTime horario_fin { get; set; }
        public int precio_final { get; set; }


         
    }
}
