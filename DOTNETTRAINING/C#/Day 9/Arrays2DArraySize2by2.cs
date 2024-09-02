using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //4. Write a program to Initialize and Display a 2 * 2 Matrix
    internal class Arrays2DArraySize2by2
    {
        public static void Main(string[] args)
        {
            //initialization
            int[,] arr1 = new int[2, 2] { { 1, 2 }, { 2, 3 } };
            int i, j; 

            //display
            Console.WriteLine("Array values are");
            for (i = 0; i < 2; i++)
            {
                for (j=0;  j<2;  j++)
                {
                   Console.Write("  {0}", arr1[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
