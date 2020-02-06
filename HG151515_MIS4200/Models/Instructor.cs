using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HG151515_MIS4200.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }
        public string instructorfirstName { get; set; }
        public string instructorlastName { get; set; }
        public string instructorEmail { get; set; }
        public string instructorPhone { get; set; }

        //add any other fields appropriate 

        //instructor is on the one side of the one to many wit coursedetail
        //indicate with ICollection 

        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}