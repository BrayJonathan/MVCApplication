using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCApplication.Entities
{
    public class MVCApplicationContext : DbContext
    {
        #region Constructor
        public MVCApplicationContext() : base("ConnectionString")
        {

        }
        #endregion

        #region DbSet
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRoom { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        #endregion

        #region Method
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        #endregion

    }
}