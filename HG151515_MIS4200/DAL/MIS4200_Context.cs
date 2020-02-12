using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HG151515_MIS4200.Models;
using System.Data.Entity;

namespace HG151515_MIS4200.DAL
{
    public class MIS4200_Context : DbContext
    {
       

        public MIS4200_Context() : base ("name=DefaultConnection")
        {
            //setInitializer statement here
            //add the setinitilizer statement here
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200_Context, HG151515_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }

        //add this method it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}