using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Arrays2DAskUser
    {
        public static void Main(string[] args)
        {
            //declaration
            int[,] arr1 = new int[2, 2];
            int i, j;

            //Accept
            Console.WriteLine("Enter the Array Values");
            for (i=0;i<2;i++)
            {
                for (j=0; j<2;j++)
                    {
                        arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            
            //display
            Console.WriteLine("Array values are");
            for (i = 0; i < 2; i++)
            {
                for (j=0;  j<2;  j++)
                {
                    Console.Write("  {0}", arr1[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
