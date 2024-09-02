using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //5. Write a program to Accept and Display a 3 * 3 Matrix
    internal class Arrays2DArraySize3by3
    {
        public static void Main(string[] args)
        {
            //initialization
            int[,] arr1 = new int[3, 3];
            int i, j;


            //Accept Values 
            Console.WriteLine("Enter array values");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            //display values
            Console.WriteLine("Array values are");
            for (i = 0; i < 3; i++)
            {
                for (j=0;  j<3;  j++)
                {
                   Console.Write("    {0}", arr1[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}


