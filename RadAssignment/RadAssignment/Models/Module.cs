using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadAssignment.Models
{
    [Table("Module")]
    public class Module
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Module ID")]
        public int ModuleID { get; set; }

        [Display(Name = "Module Name")]
        public string ModuleName { get; set; }

        [ForeignKey("associatedLecture")]
        public int LectureID { get; set; }

        public virtual ICollection<Classes> ClassesInModules { get; set; }
        public virtual Lecture associatedLecture { get; set; }

    }
}