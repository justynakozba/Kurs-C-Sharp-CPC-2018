﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JustynaKozbaLab8.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_9B1FC5_cpc20181Entities : DbContext
    {
        public DB_9B1FC5_cpc20181Entities()
            : base("name=DB_9B1FC5_cpc20181Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<JustynaKozbaData> JustynaKozbaData { get; set; }
        public virtual DbSet<JustynaKozbaUsers> JustynaKozbaUsers { get; set; }
    }
}
