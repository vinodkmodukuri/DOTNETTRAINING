using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1.Properties
{
    internal class FindGreatestNumberIfElse
    {
        public static void Main(string[] args)
        {
            int value1, value2, value3;
            Console.WriteLine("Enter the value1");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value2");
            value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value3");
            value3 = Convert.ToInt32(Console.ReadLine());

            if (value1 > value2 && value1 > value3)
            {
                Console.WriteLine("The value 1 {0} is the greatest value", value1);
            }
            else if (value2 > value1 && value2 > value3)
            {
                Console.WriteLine("The value 2 {0} is the greatest value", value2);

            }
            else
            {
                Console.WriteLine("The value 3 {0} is the greatest value", value3);

            }

        }
    }
}

/*
switch case
----------------------
It executes one statement from multiple conditions. It is like if..else..if ladder.

syntax:
----------
switch(expression)
{
case constantexpressin1:
//statements;
break;
case constantexpression2:
//statements;
break;
case constantexpression3:
//statements;
break;
....
...
...
default:
//statements;
break;
}
 */
