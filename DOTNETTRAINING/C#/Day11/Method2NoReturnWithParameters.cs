using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Method2NoReturnWithParameters
    {
        //1. Method with no return type and with parameters 
        //void means - no return type 
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The sum of two numbers is {0}", c);
        }
        public static void Main(string[] args)
        {
            Method2NoReturnWithParameters obj = new Method2NoReturnWithParameters();
            obj.Add(4,1);

            //Ask the user to enter the values 
            int num1, num2;
            Console.WriteLine("Enter two number (num1 and num2):");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            // Calling the method with user-provided values
            obj.Add(num1, num2);

            // Wait for user input before closing
            Console.ReadLine();
        }
    }
}
