using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class LinqDemoStringArray
    {

        public static void Main(string[] args)
        {

            // Step 1: Specify or the data source
            string[] seasons = new string[] { "Winter", "Spring", "Summer", "Fall" };

            //Step 2: Create the query
            var query = from k in seasons
                            /*select season*/
                            //select k.ToUpper()
                            //select k.ToLower()
                            //where k.Length == 6
                            orderby k
                        select k;


            //Step 3: Execute the query 
            Console.WriteLine("Four seasons are:");
            foreach (string s in query)
            {
                Console.WriteLine(s);

            }
            Console.ReadKey();
        }
    }
}

