﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TP_20162CEntities : DbContext
    {
        public TP_20162CEntities()
            : base("name=TP_20162CEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cocheras> Cocheras { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
