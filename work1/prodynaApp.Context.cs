﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace work1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class prodyna_serbiaEntities2 : DbContext
    {
        public prodyna_serbiaEntities2()
            : base("name=prodyna_serbiaEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<employees> employees { get; set; }
        public DbSet<roles> roles { get; set; }
        public DbSet<skills> skills { get; set; }
        public DbSet<team_skills> team_skills { get; set; }
        public DbSet<teams> teams { get; set; }
    }
}