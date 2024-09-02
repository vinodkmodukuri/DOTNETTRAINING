using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class DoWhileDisplayParticularMultiplicationTable
    {
        public static void Main(string[] args)
        {
            /*do..while
             * Write a program to accept an multiplication table number
             * and display that particular multiplication table.
             * eg: 5 * 1 = 5
             * 5 * 2 = 10
             * ......
             * 5 * 10 = 50
             */

            int i=1;
            int j;
            int answer;
            Console.WriteLine("Enter the table number");
            j = Convert.ToInt32(Console.ReadLine());
            do
            {
                answer = i * j;
                Console.WriteLine("{0} * {1} = {2}", j, i, answer);
                i++;
            }
            while (i <= 10);

            Console.ReadKey();
        }
    }
}
