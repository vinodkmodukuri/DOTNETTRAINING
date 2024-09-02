using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirstApproach
{
    internal class Program
    {

        public void Insert()
        {
            automobilestoreEntities myobj2 = new automobilestoreEntities();
            Product myobj3 = new Product();

            int id, price;
            string pname;
            Console.WriteLine("Enter the product id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of the product");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the product name");
            pname = Console.ReadLine();

            myobj3.ProductID = id;
            myobj3.Productname = pname;
            myobj3.ProductPrice = price;
            myobj2.Products.Add(myobj3);
            myobj2.SaveChanges();
            Console.WriteLine("1 record inserted sucessfully");
        }

        public void Update()
        {
            int id;
            Console.WriteLine("Enter the customer ID to update the record");
            id = Convert.ToInt32(Console.ReadLine());
            automobilestoreEntities myobj2 = new automobilestoreEntities();
            var result = myobj2.Products.Find(id);
            if (result != null)
            {
                result.Productname = "Break Pads";
                myobj2.SaveChanges();
            }
            else
            {
                Console.WriteLine("Product ID does not exist");
            }
        }

        public void Display()
        {
            automobilestoreEntities myobj2 = new automobilestoreEntities();
            var result = myobj2.Products;
            foreach (var item in result)
            {
                Console.WriteLine("Product ID is {0}", item.ProductID);
                Console.WriteLine("Product Name is {0}", item.Productname);
                Console.WriteLine("Product Price is {0}", item.ProductPrice);
            }

        }

        static void Main(string[] args)
        {
            Program myobj = new Program();
            myobj.Insert();

            //myobj.Update();

            Console.ReadLine();
        }
    }
}
