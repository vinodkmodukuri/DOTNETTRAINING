using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class DoWhileDisplaySumOfDigitsSquare
    {
       public static void Main(string[] args)
        {
            //Write a program to accept a number and display the sum of the digits square.
            //eg: 125 = 1 * 1 + 2 * 2 + 5 * 5 = 1 + 4 + 25 = 30
            int i, j;
            int sum = 0;
            int square =0;
            Console.WriteLine("Enter i value");
            i = Convert.ToInt32(Console.ReadLine());

            do
            {
                j= i % 10;
                square = j * j;
                Console.WriteLine(square);
                sum += square;
                i = i / 10;
            }
            while (i != 0);
            Console.WriteLine("The sum of digits square is {0}", sum);
            Console.ReadLine();

        }
    }
}
