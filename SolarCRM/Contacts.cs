using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarCRM
{
    //Create a model class
    internal class Contacts
    {
        [Key] //represents a unique identifier for each contact 

        //Properties of the Contacts class 
        public int id { get; set; }
        public string Contact_title { get; set; }
        public string Contact_firstName { get; set; }
        public string Contact_middleName { get; set; }
        public string Contact_lastName { get; set; }
        public string Lead_Referral_Source { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Industry { get; set; }
        public string Address_Street { get; set; }
        public string Address_City { get; set; }
        public string Address_State { get; set; }
        public string Address_PostalCode { get; set; }    
        public string Address_Country { get; set; }

        public string PhoneNumber {  get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
    }
}
