using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Arrays1DAcceptArraySize
    {

        //Single Dimensional Array
        //3. Write a program to Accept Array Size, Accept and Display Values
        public static void Main(string[] args)
        {
            //Accept Array Size
            int j = 1;
            Console.WriteLine("Enter the array size");
            j = Convert.ToInt32(Console.ReadLine());
            
            int[] arr1 = new int[j];
            int i;

            //Accept Values 
            Console.WriteLine("Enter values ");
            for (i = 0; i < j; i++)
            {
               arr1[i] =  Convert.ToInt32(Console.ReadLine());
            }

            //Display
            Console.WriteLine("Values are");
            for(i=0; i<j;i++)
            {
                Console.Write("  {0} ", arr1[i]);
            }
            Console.ReadKey();
        }

    }
}
