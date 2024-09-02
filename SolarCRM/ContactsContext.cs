using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarCRM
{

    //Create ContactsContext class. This class will handle our database operations.
    //ContactsContext class inherits from DbContext
    internal class ContactsContext : DbContext
    {
        public ContactsContext() : base ("cssolarcrm") //cssolarcrm is the connection string name which in the App.Config 
        {

        }

        public DbSet<Contacts> CRMContacts { get; set; } //DbSet<Contacts> that represents the Contacts table in the database.
    }
}
