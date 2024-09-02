using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ForLoopDisplay10To20Numbers
    {
        public static void Main(string[] args)
        {
            //Write a program to display 10 to 20 numbers.

            int i = 10; 
            for (i=10; i<=20; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

    }
}
