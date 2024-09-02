using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class OneDAsParameter
    {
        public void display(string[] test1) //Create an array and this method accept array as parameter 
        {
            for (int i = 0; i < test1.Length; i++)
            {
                Console.WriteLine(test1[i]);
            }

        }
        public static void Main(string[] args)
        {
           string[] cities = new string[] { "Dallas", "Oklahoma Ciy", "Austin" }; //int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
           OneDAsParameter obj = new OneDAsParameter(); //Create an object for your class
            obj.display(cities);
            Console.ReadLine();
        }
    }
}