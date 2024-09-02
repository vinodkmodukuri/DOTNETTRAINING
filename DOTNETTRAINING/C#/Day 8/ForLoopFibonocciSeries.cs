using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ForLoopFibonocciSeries
    {
        public static void Main(string[] args)
        {
            /*15. Write a program to accept a number and display the fibonocci series.
            eg: 0 1 1 2 3 5 8 13 21...
            fibonocci series means adding the previous two numbers is the third number.
            eg: 0+1=1
                1+1=2
                1+2=3
             */

            int num1=0, num2=1,i ,num3, number;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2 + "");
            for (i = 2; i < number;i++) 
            {
                num3 = num1 + num2;
                num1 = num2;
                num2= num3;
                Console.WriteLine(num3);
            }

            Console.ReadLine();
        }
    }
}
