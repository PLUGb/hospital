﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hospital.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class poliklinikEntities1 : DbContext
    {
        public poliklinikEntities1()
            : base("name=poliklinikEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<@class> @class { get; set; }
        public virtual DbSet<doctor> doctor { get; set; }
        public virtual DbSet<history> history { get; set; }
        public virtual DbSet<patien_doctor> patien_doctor { get; set; }
        public virtual DbSet<patient> patient { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}
