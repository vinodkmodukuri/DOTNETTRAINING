using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class FindGreatestNumber
    {
        /*Write a program to accept three numbers and display the 
        greatest number.
        */
        public static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter the number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= number2)
            {
                Console.WriteLine("Number 1 value is: {0} and it is greater than or Equal to than value B: {1}", number1, number2);

            }
            else
            {
                Console.WriteLine("Number 2 value is: {0} and it is less than value B: {1}", number1, number2);
            }
        }

    }
}


/*
 * if..else..if ladder
---------------------
It executes one condition from multiple statements.

syntax:
------------
if(condition)
{
//statements;
}
else if(condition)
{
//statements;
}
else if(condition)
{
//statements;
}
else
{
//statements;
}

*/
