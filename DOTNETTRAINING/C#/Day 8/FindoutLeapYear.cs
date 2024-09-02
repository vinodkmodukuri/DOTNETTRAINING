using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class FindoutLeapYear
    {
        public static void Main(string[] args)
        {
            /*All years which are perfectly divisible by 4 are leap years except for century years (years ending with 00),
             * which are leap years only if they are perfectly divisible by 400.
             */
            int year;
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year%400 == 0)
            {
                Console.WriteLine("Entered Year {0} is a leap year", year);
            }

            else if (year % 100 == 0)
            {
                Console.WriteLine("Entered Year {0} is not a leap year", year);

            }
            else if( year % 4 == 0)
            {
                Console.WriteLine("Entered Year {0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("Entered year {0} is not a leap year", year);
            }
            Console.ReadLine();
        }
    }
}
