using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class LogicalOperators
    {
        public static void Main(string[] args)
        {
            /* Logical Operators  
             * (&&) AND 
             * (||) OR
             * (!) NOT
             * (^) CARROT or CAP
             */


            int num1;
            int num2;
            bool num3 ;

            Console.WriteLine("Enter the number 1"); 
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            /*Console.WriteLine("Enter the number 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            */

            //Console.WriteLine("is {0} greater than {1} {2} and {1} is eual to {2} {3}", num1, num2,num1>num2, num2, num3, num2==num3);

            num3 = (num1 == 10 && num2 == 20);

            Console.WriteLine("&& Operator: The number 1 is equal to 10 and number 2 is equal to 20 {0}", num3);

            num3 = (num1 == 10 || num2 == 20);

            Console.WriteLine(" || Operator: The number 1 is equal to 10 and number 2 is equal to 20 {0}", num3);

            num3 = !(num1 == 10);
            Console.Write("! Operator: Validating the number 1 value {0}", num3);

            num3 = (num1 == 10 ^ num2 == 20);

            Console.WriteLine(" ^ Operator: The number 1 is equal to 10 and number 2 is equal to 20 {0}", num3);

            Console.ReadLine();

        }
    }
}
