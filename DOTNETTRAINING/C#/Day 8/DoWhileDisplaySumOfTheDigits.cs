using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class DoWhileDisplaySumOfTheDigits
    {
        public static void Main(string[] args)
        {
            //Write a program to accept a number and display the sum of the digits.
            //.eg: 125 = 1 + 2 + 5 = 8
        
            int i;
            int sum = 0;
            Console.WriteLine("Enter i Value");
            i = Convert.ToInt32(Console.ReadLine());

            do                        
            {
                sum += i % 10;
                i = i / 10;
            }

            while (i !=0);
            Console.WriteLine("The sum is {0}", sum);  

            Console.ReadLine();
        }
    }
}
