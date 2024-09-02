using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ForLoopDisplayTheFactorial
    {
        public static void Main(string[] args)
        {
            //Write a program to accept a number and display the factorial of the given number.
            //factorial eg: 5 factorial = 5 * 4 * 3 * 2 * 1 = 120

            int i;
            int num;
            int factorial = 1;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
           for (i=1; i<=num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The factorial {0}", factorial);
            Console.ReadKey();

        }

    }
}
