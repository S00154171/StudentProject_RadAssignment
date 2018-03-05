using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadAssignment.Models
{
    [Table("Lecture")]
    public class Lecture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Lecture ID")]
        public int StudentID { get; set; }

        [Display(Name = "FirstName")]
        public string LectureFirstName { get; set; }

        [Display(Name = "LastName")]
        public string LectureLastName { get; set; }

        public virtual ICollection<Module> LectureInModules { get; set; }

    }
}