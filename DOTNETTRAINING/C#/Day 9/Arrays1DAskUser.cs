using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //2.Write a Program to accept an array of size 5, accept and display values

    internal class Arrays1DAskUser
    {
        public static void Main(string[] args)
        {
            //Declaration
            int[] arr1 = new int[5];
            int i;
            
            //Accept
            Console.WriteLine("Enter values ");
            for (i = 0; i < 5; i++)
            {
               arr1[i] =  Convert.ToInt32(Console.ReadLine());
            }

            //Display
            Console.WriteLine("Values are");
            for(i=0; i<5;i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
        }

    }
}
