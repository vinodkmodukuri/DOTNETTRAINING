using EFCodeFirstApproachEmployee;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproachEmployee
{
    internal class EmployeeContext :DbContext
    {
        //Create a constructor for the EmployeeContext class and add base (connection string name from App.Config file) 
        public EmployeeContext(): base("EmployeeConString")
        {

        }

        //Create the table name 
        public DbSet<Employee> Employees { get; set; }
    }
}
