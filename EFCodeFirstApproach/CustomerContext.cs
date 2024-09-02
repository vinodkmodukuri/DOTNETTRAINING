using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach
{
    internal class CustomerContext : DbContext
    {
        public CustomerContext() : base ("customer")
        { 
        
        }
        public DbSet <Customer> customers { get; set; }
    }
}
