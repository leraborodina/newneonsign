﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NeonSignWPF.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NeonSignDBEntities : DbContext
    {
        public NeonSignDBEntities()
            : base("name=NeonSignDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NeonColor> NeonColor { get; set; }
        public virtual DbSet<NeonType> NeonType { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SignForm> SignForm { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
