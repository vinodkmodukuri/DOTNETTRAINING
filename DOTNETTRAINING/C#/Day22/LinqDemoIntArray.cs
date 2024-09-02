using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class LinqDemoIntArray
    {

        public static void Main(string[] args)
        {
            // Step 1: Specify or the data source
            int[] array1 = new int[5] {11,22,33,44,55};

            //Step 2: Create the query 
            var query = from number in array1
                        select number;

            //Step 3: Execute the query 
            Console.WriteLine("Values are:");
            foreach (int i in query)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
