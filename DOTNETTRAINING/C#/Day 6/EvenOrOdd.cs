using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class EvenOrOdd
    {
        public static void Main(string[] args)
        {
            //Write a program to accept a number and display whether the number is even or odd.
            int a;
            Console.WriteLine("Enter the A value");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("A value is {0} and it is even number ", a);
            }
            else
            {

                Console.WriteLine("A value is {0} and it is odd", a);
            }
         Console.ReadKey();
        }
    }
}
