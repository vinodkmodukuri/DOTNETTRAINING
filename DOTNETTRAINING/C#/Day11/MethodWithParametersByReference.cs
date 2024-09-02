using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{

    internal class MethodWithParametersByReference
    {
        public void CalculateFinalPrice( float originalPrice, float discountPrice, ref float sellingPrice)
        {
            //original price = 80; discount price = 20, selling price=100

            // Swap originalPrice and discountPrice
            float finalPrice; 
            finalPrice = originalPrice; //FinalPrice = 80 
            originalPrice = discountPrice; //original price = 20
            discountPrice = finalPrice; //discount price = 80


            // Calculate sellingPrice
            sellingPrice = originalPrice + discountPrice;

        }
        public static void Main(string[] args)
        {

            //Before

            float originalPrice, discountPrice, sellingPrice=0;

            //Ask the user input 
            Console.WriteLine("Enter the original price, discount price");
            originalPrice = Convert.ToSingle(Console.ReadLine());
            discountPrice = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("the original price is {0}, discount price is {1}", originalPrice, discountPrice);

            //Create an instance of MethodWithParametersByReference
            MethodWithParametersByReference myobj = new MethodWithParametersByReference();

            
            // Call the CalculateFinalPrice method with ref parameters
            myobj.CalculateFinalPrice(originalPrice, discountPrice, ref sellingPrice);
            
            Console.WriteLine("After the method, the original price is  {0}, discount price is {1} and the selling price is {2} ", originalPrice, discountPrice, sellingPrice);

            Console.ReadLine();
        }
    }
}
