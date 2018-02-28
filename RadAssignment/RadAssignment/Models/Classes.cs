using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadAssignment.Models
{
    [Table("Classes")]
    public class Classes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Classes ID")]
        public int ClassesID { get; set; }

        [Display(Name = "Classes Name")]
        public string ClasseseName { get; set; }

        [ForeignKey("associatedModules")]
        public int ModuleID { get; set; }

        public virtual Module associatedModules { get; set; }

        public virtual ICollection<Student> StudentsInClasses { get; set; }

    }
}