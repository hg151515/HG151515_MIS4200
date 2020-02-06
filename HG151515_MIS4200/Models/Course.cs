using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HG151515_MIS4200.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string courseDescription { get; set; }
        public string courseLocation { get; set; }
        public DateTime courseStart { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }

        public int studentID { get; set; }
        public virtual Student Student { get; set; }

        [Key]
        public int orderID { get; set; }
    }
}