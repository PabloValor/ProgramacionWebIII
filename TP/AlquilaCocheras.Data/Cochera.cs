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
    
    public partial class Cochera
    {
        public Cochera()
        {
            this.Puntaje = new HashSet<Puntaje>();
            this.Reserva = new HashSet<Reserva>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdPropietario { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public Nullable<int> SuperficieM2 { get; set; }
        public string Imagen { get; set; }
        public Nullable<int> PrecioHora { get; set; }
        public Nullable<bool> Disponible { get; set; }
    
        public virtual Propietario Propietario { get; set; }
        public virtual ICollection<Puntaje> Puntaje { get; set; }
        public virtual ICollection<Reserva> Reserva { get; set; }
    }
}
