using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HG151515_MIS4200.Models;
using System.Data.Entity; 

namespace MIS4200context.DAL
{
	public class MIS4200context : DbContext //inherits from DbContext ()
	{
       public MIS4200context() : base ("name=DefaultConnection")
        {
            //this method is a 'constructor' and is callen when a new context is created
            //the base attribute says which connection string to use
        }

        //Include each object here. The value inside <> is the name of the class
        //the value outside should generally be the plural of the class name 
        // and is the name used to refrenece the entity in code 

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
	}
}
