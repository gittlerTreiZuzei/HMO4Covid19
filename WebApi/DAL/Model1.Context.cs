﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HMO4Covid19_dbEntities : DbContext
    {
        public HMO4Covid19_dbEntities()
            : base("name=HMO4Covid19_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Shot> Shot { get; set; }
        public virtual DbSet<shot4Client> shot4Client { get; set; }
        public virtual DbSet<T_Address> T_Address { get; set; }
    }
}
