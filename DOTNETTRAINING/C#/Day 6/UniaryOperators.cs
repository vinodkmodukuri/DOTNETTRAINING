using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class UniaryOperators
    {
        public static void Main(string[] args)
        {
            //Uniary Operatos (++, --) OR Prefix Increment and Decrement | Postfix Increment and Decrement 

            int num1;
            int num2;
            Console.WriteLine("Enter the number 1"); 
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number 1 is {0}", num1);

            Console.WriteLine("=============Pre-Increment ++num1 Operator=======");
            num2 = ++num1; 
            /*pre-increment
             * ++num1 means 
             * num2 = num1+1; 
             * num 2 = 5
             */
            Console.WriteLine("After pre increment number 1 value is: {0} \t\t number 2 value is {1}", num1, num2);


            Console.WriteLine("=============Post-Increment num1++ Operator=======");
            num2 = num1++; //post-increment, num1++ means num1 = num1+1
            Console.WriteLine("After post increment number 1 value is: {0} \t\t number 2 value is  {1}", num1, num2);

            Console.WriteLine("=============Pre-Decrement --num1 Operator=======");
            num2 = --num1;
            Console.WriteLine("After pre decrement number 1 value is: {0}, \t\t number 2 value is: {1}", num1, num2);
            
            Console.WriteLine("=============Post-Decrement num1-- Operator=======");
            num2 = num1--;
            Console.WriteLine("After post decrement number 1 value is {0} \t\t number 2 value is: {1}", num1, num2);
           
            Console.ReadLine(); 
 
        }

    }
}
