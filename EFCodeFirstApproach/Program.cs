using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach
{
    internal class Program
    {

        public void Insert()
        {
            CustomerContext myobj2 = new CustomerContext();
            Customer myobj3 = new Customer();
            int ID;
            string name, city, address;
       
            Console.WriteLine("Enter the Customer ID");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the customer name");
            name = Console.ReadLine();

            Console.WriteLine("Enter the city");
            city = Console.ReadLine();

            Console.WriteLine("Enter the address");
            address = Console.ReadLine();


            myobj3.CustomerID = ID;
            myobj3.CustomerName = name;
            myobj3.City = city;
            myobj3.Address = address;
            myobj2.customers.Add(myobj3);
            myobj2.SaveChanges();
        }


        public void Update()
        {
            int id;
            Console.WriteLine("Enter the customer ID to update the record");
            id = Convert.ToInt32(Console.ReadLine());
            CustomerContext myobj2 = new CustomerContext();
            var result = myobj2.customers.Find(id);
            if (result != null)
            {
                result.CustomerName = "Tom";
                myobj2.SaveChanges();
            }
            else
            {
                Console.WriteLine("Customer ID does not exist");
            }
        }

        public void Display()
        {
            CustomerContext myobj2 = new CustomerContext();
            var result = myobj2.customers;
            foreach (var item in result)
            {
                Console.WriteLine("Customer ID is {0}", item.CustomerID);
                Console.WriteLine("Customer Name is {0}",item.CustomerName);
                Console.WriteLine("Customer City is {0}", item.City);
                Console.WriteLine("Customer Address is {0}", item.Address);

            }


        }

        public void Delete()
        {
            int ID;
            Console.WriteLine("Enter the customer ID to delete the record");
            ID = Convert.ToInt32(Console.ReadLine());
            CustomerContext myobj2 = new CustomerContext();
            var result = myobj2.customers.Find(ID);
            if (result != null)
            {
                Console.WriteLine("Deleting {0}", result.CustomerID);
                myobj2.customers.Remove(result);
                myobj2.SaveChanges();
          
            }
            else
            {
                Console.WriteLine("Customer ID does not exist");
            }



        }
        static void Main(string[] args)
        {
           Program myobj = new Program();

            myobj.Insert();
            //myobj.Update();
             myobj.Display();
            // myobj.Delete();

            Console.ReadLine();
        }
    }
}
