using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach
{
    internal class Customer
    {
        [Key]   
        public int CustomerID { get; set; } //get to read the value and set to assign the value. Get and set will call as public properties 
        public string CustomerName { get; set; } 
        public string Address { get; set; }
        public string City { get; set; }

    }
}
