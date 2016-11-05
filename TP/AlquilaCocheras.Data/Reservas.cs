//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlquilaCocheras.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservas
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdCochera { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public decimal CantidadHoras { get; set; }
        public decimal Precio { get; set; }
        public System.DateTime FechaCarga { get; set; }
        public short Puntuacion { get; set; }
    
        public virtual Cocheras Cocheras { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
