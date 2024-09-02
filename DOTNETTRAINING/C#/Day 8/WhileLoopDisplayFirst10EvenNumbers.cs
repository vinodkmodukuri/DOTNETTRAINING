using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class WhileLoopDisplayFirst10EvenNumbers
    {
        public static void Main(string[] args)
        {
            //3. Write a program to display the first 10 even numbers.

           int i = 0;
           int j = 0;
           while (i <= 20)
            {
                j = (i % 2);
                if (j == 0)
                {
                    Console.WriteLine(i);
                }
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
