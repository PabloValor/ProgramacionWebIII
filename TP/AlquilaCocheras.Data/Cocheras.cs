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
    
    public partial class Cocheras
    {
        public Cocheras()
        {
            this.Reservas = new HashSet<Reservas>();
        }
    
        public int IdCochera { get; set; }
        public int IdPropietario { get; set; }
        public string Ubicacion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string Descripcion { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public int MetrosCuadrados { get; set; }
        public short TipoVehiculo { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}
