using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class WhileLoopDisplaySumOfFirst10Numbers
    {
        public static void Main(String[] args)
        {
            //2. Write a program to display the sum of first 10 numbers.
            int sum =0;
            int i = 1; //initialization
            while (i <= 10)//while(condition)
            {
                sum = sum + i;
                i++; 
            }
            Console.WriteLine("The sum of first 10 numbers is {0} ", sum);
            Console.ReadLine();
        }
    }
}

/*syntax:
-------------
initialization;
while(condition)
{
//statements;
increment/decrement;
}
 */

