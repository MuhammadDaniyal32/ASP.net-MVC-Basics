﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cascading_dropdown.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Asp_DaniyalEntities : DbContext
    {
        public Asp_DaniyalEntities()
            : base("name=Asp_DaniyalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<disease_tbl> disease_tbl { get; set; }
        public virtual DbSet<Docter_tbl> Docter_tbl { get; set; }
    }
}