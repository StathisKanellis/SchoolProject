using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolProject.Models
{
    public class MyDatabase : DbContext
    {
        public MyDatabase() : base("SchoolProject")
        {

        }


        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<SchoolProject.Models.Trainer> Trainers { get; set; }

        public System.Data.Entity.DbSet<SchoolProject.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<SchoolProject.Models.Assignment> Assignments { get; set; }
    }
}