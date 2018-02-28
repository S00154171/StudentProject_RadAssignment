using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RadAssignment.Models
{
    public class ContextClass :DbContext
    {
        public ContextClass() : base ("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Classes> Class { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Module> Modules { get; set; }


    }
}