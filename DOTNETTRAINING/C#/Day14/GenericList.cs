using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class GenericList
    {
        public static void Main(string[] args)
        {
            List<int> myobj = new List<int>();
            myobj.Add(1);
            myobj.Add(2);
            myobj.Add(13);
            myobj.Add(16);
            foreach (int i in myobj)
            {
                Console.WriteLine(i);
            }

            List<string> myobj2 = new List<string>();
            myobj2.Add("Ram");
            myobj2.Add("Mohan");
            myobj2.Add("Rao");
            foreach(string i in myobj2)
            {

             Console.WriteLine(i); 
            }
            Console.ReadLine() ;
        }
    }
}
