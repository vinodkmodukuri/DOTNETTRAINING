using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class WhileLoopDisplay1To10Numbers
    {
        public static void Main(string[] args)
        {
            //1. Write a program to display 1 to 10 numbers.
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
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