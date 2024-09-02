using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class PositiveOrNegative
    {
        public static void Main(string[] args)
        {
            int number1;
            Console.WriteLine("Enter the number");
            number1=Convert.ToInt32(Console.ReadLine());

            if (number1 >= 0)
            {
                Console.WriteLine("A value is {0} and it is positive", number1);

            }
            else
            {
                Console.WriteLine("A value is {0} and it is negative", number1);

            }
            Console.ReadKey();


        }
    }
}
