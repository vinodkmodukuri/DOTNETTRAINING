using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{

    internal class MethodWithParametersByValue
    {
        public void CalculateFinalPrice(float originalPrice, float discountPrice)
        {
            //original price = 80; discount price = 20

            float finalPrice; 
            finalPrice = originalPrice; //FinalPrice = 80 
            originalPrice = discountPrice; //original price = 20
            discountPrice = finalPrice; //discount price = 80

        }
        public static void Main(string[] args)
        {

            //Before

            float originalPrice, discountPrice;
            Console.WriteLine("Enter the original price, discount price");
            originalPrice = Convert.ToSingle(Console.ReadLine());
            discountPrice = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("the original price is {0}, discount price is {1}", originalPrice, discountPrice);

            //After 
            MethodWithParametersByValue myobj = new MethodWithParametersByValue();

            myobj.CalculateFinalPrice(originalPrice, discountPrice);
           Console.WriteLine("After the method, the original price is  {0} and the discount price {1} ", originalPrice, discountPrice);

            Console.ReadLine();
        }
    }
}
