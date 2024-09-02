using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class DictionaryGeneric
    {
        public static void Main(string[] args)
        {
            Dictionary<int, int> myobj = new Dictionary<int, int>();
            myobj.Add(1, 2);
            myobj.Add(2, 3);
            myobj.Add(3, 4);
            myobj.Add(4, 5);
            foreach (var i in myobj)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.ReadLine();
        }
    }
}
