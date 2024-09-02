using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //1.Write a Program to initialize an array of size 5 and display values
    internal class Arrays1D
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array values are");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
        }

    }
}
