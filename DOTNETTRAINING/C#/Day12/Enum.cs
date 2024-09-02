using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    enum Days { sun, mon, tue, wed, thurs, fri, sat }
    internal class Enum
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("The first day of the week is {0}",Days.sun);

            //If we want the value to be display, we need to convert it 

            Console.WriteLine("The first day of the week is {0}", Convert.ToInt32(Days.sun));

            Console.WriteLine("The first day of the week is {0}", Days.sat);

            Console.WriteLine("The first day of the week is {0}", (int) (Days.sat));

            Console.ReadLine();
        }
    }
}
