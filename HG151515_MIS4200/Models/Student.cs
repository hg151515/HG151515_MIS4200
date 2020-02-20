using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HG151515_MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string studentfirstName { get; set; }
        public string studentlastName { get; set; }
        public string studentEmail { get; set; }
        public string studentPhone { get; set; }
        public DateTime enrollDate { get; set; }

        //add any other fields as appropriate

        //represent a students number of classesi with an ICollection 
        //the syntax says we are creating an ICollection of Order objects
        //(the name inside the <> is the object name)
        //the local name of the collection will be Order 
        //(the object name and the local name don't have to be the same)

        public ICollection<CourseDetail> CourseDetail { get; set; }


    }
}