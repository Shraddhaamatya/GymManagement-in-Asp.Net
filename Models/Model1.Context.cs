﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GymManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GymDBEntities : DbContext
    {
        public GymDBEntities()
            : base("name=GymDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Role> Roles { get; set; }
        public DbSet<tblAttendance> tblAttendances { get; set; }
        public DbSet<tblGallery> tblGalleries { get; set; }
        public DbSet<tblMeasurement> tblMeasurements { get; set; }
        public DbSet<tblMembership> tblMemberships { get; set; }
        public DbSet<tblMembershipType> tblMembershipTypes { get; set; }
        public DbSet<tblPayment> tblPayments { get; set; }
        public DbSet<tblProtein> tblProteins { get; set; }
        public DbSet<tblShift> tblShifts { get; set; }
        public DbSet<tblUser> tblUsers { get; set; }
        public DbSet<tblWorkout> tblWorkouts { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}