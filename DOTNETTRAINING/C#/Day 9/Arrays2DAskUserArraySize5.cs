using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{ 
  //2. Write a program to accept Array of Size 5, Accept and Display Values

    internal class Arrays2DAskUserArraySize5
    {
        public static void Main(string[] args)
        {
            //declaration
            int[,] arr1 = new int[5, 5];
            
            int i, j;

            //Accept
            Console.WriteLine("Enter the Array Values");
            for (i=0;i<5;i++)
            {
                for (j=0; j<5;j++)
                    {
                        arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            
            //display
            Console.WriteLine("Array values are");
            for (i = 0; i < 5; i++)
            {
                for (j=0;  j<5;  j++)
                {
                    Console.Write("  {0}", arr1[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
