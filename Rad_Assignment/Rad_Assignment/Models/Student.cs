using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadAssignment.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Students ID")]
        public int StudentID { get; set; }

        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [ForeignKey("associatedClasses")]
        public int ModuleID { get; set; }

        public virtual Classes associatedClasses { get; set; }

    }
}