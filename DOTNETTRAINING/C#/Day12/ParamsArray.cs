using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ParamsArray
    {

        public void Add(params int[] arr1)
        {
            int result = 0;
            foreach (int i in arr1)
            {
                result += i;
            }

           /* for(int i = 0; i < arr1.Length; i++)
            {
                result += arr1[i];
            }*/
            Console.WriteLine("The total is {0}", result);
        }
        public static void Main(String[] args)
        {
            ParamsArray obj = new ParamsArray();
            obj.Add(1, 2, 3, 4, 5);
            obj.Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.ReadLine();
        }
    }
}
