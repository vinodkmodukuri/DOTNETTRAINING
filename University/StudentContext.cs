using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class StudentContext : DbContext
    {
        public StudentContext() : base ("csStudent")
        { 

        }

        public DbSet<Student> Students { get; set; }    
    }
}
