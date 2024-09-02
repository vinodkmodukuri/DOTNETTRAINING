using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class TwoDAsParameters
    {
        public static void display(int[,] test1)
        { 
        
            for (int i = 0; i <2;  i++)
            {
                for (int j=0; j<2; j++)
                {
                    Console.Write("  {0}", test1[i,j]);
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2] { { 1, 2 }, { 2, 3 } };
            TwoDAsParameters.display(arr1);
            Console.ReadLine();
        }
    }
}
