﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InternRegistrationProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InternEvaluationDatabaseEntities1 : DbContext
    {
        public InternEvaluationDatabaseEntities1()
            : base("name=InternEvaluationDatabaseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<InternInformation> InternInformation { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
