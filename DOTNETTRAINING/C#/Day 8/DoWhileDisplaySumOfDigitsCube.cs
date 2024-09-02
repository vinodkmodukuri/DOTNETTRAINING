using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class DoWhileDisplaySumOfDigitsCube
    {
       public static void Main(string[] args)
        {
            //Write a program to accept a number and display the sum of the digits cube.
            //eg: 125 = 1 * 1 * 1 + 2 * 2 * 2 + 5 * 5 * 5 = 1 + 8 + 125 = 134
            int i;
            int j;
            int sum = 0;
            int cube =0;
            Console.WriteLine("Enter i value");
            i = Convert.ToInt32(Console.ReadLine());

            do
            {
                j= i % 10;
                cube = j * j * j;
                Console.WriteLine(cube);
                sum += cube;
                i = i / 10;
            }
            while (i != 0);
            Console.WriteLine("The sum of digits cube is {0}", sum);
            Console.ReadLine();

        }
    }
}
