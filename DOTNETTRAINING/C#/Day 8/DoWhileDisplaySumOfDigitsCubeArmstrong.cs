using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class DoWhileDisplaySumOfDigitsCubeArmstrong
    {
       public static void Main(string[] args)
        {
            // Write a program to accept a number and check whether the number is an Armstrong number or not.
            //Armstrong number means the sum of the digits cube should be equal to the given number.
            //eg: 153 = 1 * 1 * 1 + 5 * 5 * 5 + 3 * 3 * 3 = 1 + 125 + 27 = 153.
            int i, temp,j, sum=0;          
            Console.WriteLine("Enter i value");
            i = Convert.ToInt32(Console.ReadLine());
            temp = i;
            do
            {
                j = i % 10;
                sum += j * j * j;
                i = i / 10;
            }
            while (i != 0);
            if (temp == sum)
            {
                Console.WriteLine("the number is an Armstrong number");
            }
            else
                Console.WriteLine("the number is an not an Armstrong number");
            Console.ReadLine();

        }
    }
}
