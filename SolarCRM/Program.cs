using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarCRM
{
    internal class Program
    {
        public void Insert()
        {
            //Variable Declarations
            int cID;
            string cTitle, cFirstName, cMiddleName, cLastName, cLeadReferral, CJobTitle, CCompanyName, cCompanyIndustry, cAddressStreet, cAddressCity, cAddressState, cPostalCode, cCountry, cPhoneNumber, cEmail, cLinkedIN;

            //Ask the user input and store them in the variables 
            Console.WriteLine("Enter the contact ID"); 
            cID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the contact salutation");
            cTitle = Console.ReadLine();
            Console.WriteLine("Enter the contact first name");
            cFirstName = Console.ReadLine();
            Console.WriteLine("Enter the contact middle name");
            cMiddleName = Console.ReadLine();
            Console.WriteLine("Enter the contact last name");
            cLastName = Console.ReadLine();
            Console.WriteLine("Enter the contact lead referral");
            cLeadReferral = Console.ReadLine();
            Console.WriteLine("Enter the contact job title");
            CJobTitle = Console.ReadLine();
            Console.WriteLine("Enter the contact company name");
            CCompanyName = Console.ReadLine();
            Console.WriteLine("Enter the contact company industry");
            cCompanyIndustry = Console.ReadLine();
            Console.WriteLine("Enter the contact Address street");
            cAddressStreet = Console.ReadLine();
            Console.WriteLine("Enter the contact address city");
            cAddressCity = Console.ReadLine();
            Console.WriteLine("Enter the contact address state");
            cAddressState = Console.ReadLine();
            Console.WriteLine("Enter the contact address postal code ");
            cPostalCode = Console.ReadLine();
            Console.WriteLine("Enter the contact country");
            cCountry = Console.ReadLine();
            Console.WriteLine("Enter the contact Phone Number");
            cPhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the contact email");
            cEmail = Console.ReadLine();
            Console.WriteLine("Enter the contact LinkedIn");
            cLinkedIN = Console.ReadLine();

            // creates an instance of ContactsContext  - To interact with Database
            ContactsContext contactsContext = new ContactsContext();

            //creates an instance of the Contacts - contacts object will hold contact details that will be added to the database 
            Contacts contacts = new Contacts();

            //Map the contact details to the Contacts object
            contacts.id = cID;
            contacts.Contact_title = cTitle;
            contacts.Contact_firstName = cFirstName;
            contacts.Contact_middleName = cMiddleName;
            contacts.Contact_lastName = cLastName;
            contacts.Lead_Referral_Source = cLeadReferral;
            contacts.Title = CJobTitle;
            contacts.Company = CCompanyName;
            contacts.Industry = cCompanyIndustry;
            contacts.Address_Street = cAddressStreet;
            contacts.Address_City = cAddressCity;
            contacts.Address_State = cAddressState;
            contacts.Address_PostalCode = cPostalCode;
            contacts.Address_Country = cCountry;
            contacts.PhoneNumber= cPhoneNumber;
            contacts.Email= cEmail;
            contacts.LinkedIn = cLinkedIN;

            //It adds the contacts object to the CRMContacts DbSet, which represents the Contacts table in the database.
            contactsContext.CRMContacts.Add(contacts);
            
            // Saves the changes to the database
            contactsContext.SaveChanges();

            Console.WriteLine("Data inserted successfully");


        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Insert();
            Console.ReadLine();
        }
    }
}

