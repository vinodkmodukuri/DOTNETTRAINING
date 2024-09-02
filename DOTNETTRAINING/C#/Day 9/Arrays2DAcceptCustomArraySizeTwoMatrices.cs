using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //Two Dimensional Array
    //8. Write a program to accept row size and column size of Two matrices, Accept and Display Values
    internal class Arrays2DAcceptCustomArraySizeTwoMatrices
    {
        public static void Main(string[] args)
        {
            //initialization and accept ArraySize
            int a = 1, b = 1, c = 1, d = 1, i, j;
            Console.WriteLine("Enter the Array 1 row size: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Array 1 column size: ", b);
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Array 2 column size: ", c);
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Array 2 column size: ", d);
            d = Convert.ToInt32(Console.ReadLine());

            
            //declaratiion
            int[,] arr1 = new int[a, b];
            int[,] arr2 = new int[c, d];

           // int i, j;

            //Accept values for Array 1
            Console.WriteLine("Accept Array 1 values");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Accept values Array 2
            Console.WriteLine("Accept  Array 2 values");
            for (i = 0; i < c; i++)
            {
                for (j = 0; j<d; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Display Array 1
            Console.WriteLine("Array values are");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {

                    Console.Write("  {0}", arr1[i, j]);
                }
                Console.WriteLine();
            }

            //Display Array 2
            Console.WriteLine("Array values are");
            for (i = 0; i < c; i++)
            {
                for (j = 0; j < d; j++)
                {

                    Console.Write("  {0}", arr2[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


    }
}

