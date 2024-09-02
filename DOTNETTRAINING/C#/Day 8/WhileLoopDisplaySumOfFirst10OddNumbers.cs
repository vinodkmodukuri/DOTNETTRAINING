using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class WhileLoopDisplaySumOfFirst10OddNumbers
    {
        public static  void Main(string[] args)
        {
            //Write a program to display the sum of first 10 odd numbers.

            int i = 0;
            int j = 0;           
            int sum = 0;
            while(i<=20)
            {
                j = (i % 2);
                if (j == 1)
                {
                    sum = sum + i;                   
                }
                i++;
            }
            Console.WriteLine("The sum of first 10 odd numbers is {0}.", sum);
            Console.ReadKey();
        }
    }
}
