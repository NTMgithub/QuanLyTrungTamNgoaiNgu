﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TTANEntities : DbContext
    {
        public TTANEntities()
            : base("name=TTANEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DSGVTrongPhongThi> DSGVTrongPhongThis { get; set; }
        public DbSet<DSThiSinhTrongPhongThi> DSThiSinhTrongPhongThis { get; set; }
        public DbSet<GiaoVien> GiaoViens { get; set; }
        public DbSet<KhoaThi> KhoaThis { get; set; }
        public DbSet<PhongThi> PhongThis { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<ThiSinhDK> ThiSinhDKs { get; set; }
    }
}
