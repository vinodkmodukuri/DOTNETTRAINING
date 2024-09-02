using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Method4WithReturnwithParameters
    {
        //4. Method with return type and with parameter 
        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static void Main(string[] args)
        {
            Method4WithReturnwithParameters obj = new Method4WithReturnwithParameters();
           
            // Call the Add method with hardcoded values and display the result
            Console.WriteLine("The sum is {0}",obj.Add(12, 14));

            //Ask the user to enter the values 
            int a, b;
            Console.WriteLine("Enter the two sumbers");

            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());

            // Call the Add method with user-provided values and store the result
            int sum = obj.Add(a, b);
            Console.WriteLine("The sum of a {0} and b {1} is: {2}", a, b, sum);

            // Call the Add method with user-provided values
            Console.WriteLine("The sum of a {0} and b {1} is: {2}", a, b, obj.Add(a, b));

            // Pause to keep console window open
            Console.ReadKey();
        }
    }
}
