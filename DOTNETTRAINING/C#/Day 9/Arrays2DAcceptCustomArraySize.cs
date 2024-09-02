using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //Two Dimensional Array
    //7. Write a program to accept row size and column size, Accept and Display Values
    internal class Arrays2DAcceptCustomArraySize
    {
        public static void Main(string[] args)
        {
            //initialization and accept ArraySize
            int a = 1, b = 1;
            Console.WriteLine("Enter the row size: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column size: ", b);
            b = Convert.ToInt32(Console.ReadLine());

            //declaratiion
            int[,] arr1 = new int[a, b];
            int i, j;

            //Accept values
            Console.WriteLine("Accept values");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            //display
            Console.WriteLine("Array values are");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {

                    Console.Write("  {0}", arr1[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


    }
}

