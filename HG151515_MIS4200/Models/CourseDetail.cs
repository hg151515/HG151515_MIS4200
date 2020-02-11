using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HG151515_MIS4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }
        public int coursedetailDescription { get; set; }
        public DateTime coursestartTime { get; set; }

        // the next two properties link the course detial to the the course
        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        //the next two properties link othe detail with the instructor 
        public int InstructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

    }
}