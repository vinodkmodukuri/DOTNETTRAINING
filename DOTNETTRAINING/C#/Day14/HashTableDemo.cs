using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program1
{
    internal class HashTableDemo
    {
        //Hashtable demo - key vlaue pairs 
        public static void Main(string[] args)
        {
            Hashtable myhashtable = new Hashtable();
            myhashtable.Add("1", "Monday");
            myhashtable.Add("2", "Tuesday");
            myhashtable.Add("3", "Wednesday");
            myhashtable.Add("4", "Thursday");
            myhashtable.Add("5", "Friday");
            myhashtable.Add("6", "Saturday");
            myhashtable.Add("7", "Sunday");
           myhashtable.Add("8", "Sunday"); //Keys must be unique and can't be null // values can be duplicated and null
            foreach (DictionaryEntry item in myhashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
           myhashtable.Remove("8");
            Console.WriteLine("After removing the hashtable values are");
            foreach (DictionaryEntry item in myhashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.ReadLine();
        }
    }
}
