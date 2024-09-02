using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class SwitchCaseDayOfAWeek
    {
        public static void Main(string[] args)
        {

            /*Write a program to accept a number and display the corresponding day of a week.
             * eg: 1 - sunday
            */

            int number;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Day of the week is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Day of the week is Monday");
                    break;
                case 3:
                    Console.WriteLine("Day of the week is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Day of the week is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Day of the week is Tursday");
                    break;
                case 6:
                    Console.WriteLine("Day of the week is Friday");
                    break;
                case 7:
                    Console.WriteLine("Day of the week is Saturday");
                    break;
                default:
                    Console.WriteLine("Entered input is invalis {0}, enter between 1 to 7", number);
                    break;
            }

        }
    }
}
