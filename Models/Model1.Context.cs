﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_CRUD.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_CRM_CCEntities : DbContext
    {
        public DB_CRM_CCEntities()
            : base("name=DB_CRM_CCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TR_Contact> TR_Contact { get; set; }
        public DbSet<TR_Customer> TR_Customer { get; set; }
        public DbSet<TR_Role> TR_Role { get; set; }
        public DbSet<TR_TargetSetting> TR_TargetSetting { get; set; }
        public DbSet<TR_User> TR_User { get; set; }
        public DbSet<TT_CallHistory> TT_CallHistory { get; set; }
        public DbSet<TT_CallResult> TT_CallResult { get; set; }
        public DbSet<TT_CustomerProject> TT_CustomerProject { get; set; }
        public DbSet<TT_UserProject> TT_UserProject { get; set; }
    }
}
