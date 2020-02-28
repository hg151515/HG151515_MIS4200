using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace HG151515_MIS4200.Models
{
    public class Student
    {
        public System.Guid SID { get; set; }

        [StringLength(20)]
        [Required]
        public int studentID { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is required!")]
        [StringLength(20)]
        public string studentfirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is required!")]
        [StringLength(20)]
        public string studentlastName { get; set; }

        [Display(Name = "Enter student email address")]
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string studentEmail { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Student first name is required")]
        [StringLength(20)]
        public string studentPhone { get; set; }

        [Display (Name ="Start date of enrollment at University")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
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