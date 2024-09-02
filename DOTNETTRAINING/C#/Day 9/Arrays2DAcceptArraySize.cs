using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //5. Write a program to Accept Size, Accept and Display values 
    internal class Arrays2DAcceptArraySize
    {
        public static void Main(string[] args)
        {
            //initialization
            int a=1;
            Console.WriteLine("Enter the array size");
            a = Convert.ToInt32(Console.ReadLine());

            int b = 1;
            a = Convert.ToInt32(Console.ReadLine());

            int[,] arr1 = new int[a, b];
            int i, j;

            //Accept Values 
            Console.WriteLine("Enter array values");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            //display values
            Console.WriteLine("Array values are");
            for (i = 0; i < a; i++)
            {
                for (j=0;  j<b;  j++)
                {
                   Console.Write("    {0}", arr1[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}


