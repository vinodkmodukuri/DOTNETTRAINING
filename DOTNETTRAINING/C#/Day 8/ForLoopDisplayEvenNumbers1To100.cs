using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ForLoopDisplayEvenNumbers1To100
    {
        public static void Main(string[] args)
        {
            //Write a program to display only the even numbers from 1 to 100.

            int i;
            int j;
            for (i = 0; i <=100; i++)
            {
                j = i % 2;
                if (j == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
