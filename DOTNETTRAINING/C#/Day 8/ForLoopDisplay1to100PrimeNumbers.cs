using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ForLoopDisplay1to100PrimeNumbers
    {

        public static void Main(string[] args)
        {

            /*
             Let's take 5 
            1 * 5 = 5
            5 * 1 = 5 
            When you divide by 2, 3, 5 - Reminder should not be zero  

              Let's take 7
            1 * 7 = 7
            7 * 1 = 7
            When we divide 7 by 2, 3, 4, 5, 6 - Remiber should not be zero 
             */

            int i, j;

            for (i = 2; i < 100; i++)
            {
                bool isPrimeNumber = true;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                    }
                }
                if (isPrimeNumber)
                {                    
                    Console.WriteLine("{0}", i);

                }
            }
            Console.ReadKey();

        }
    }
}
