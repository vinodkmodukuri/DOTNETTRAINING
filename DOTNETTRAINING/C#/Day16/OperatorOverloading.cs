using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class CountNumber
    {
        public int a;
        public CountNumber(int b)
        {
            a = b;
        }
        public static CountNumber operator ++ (CountNumber obj)
        {
            return new CountNumber(obj.a+1);

        }
    }

    internal class OperatorOverloading
    {
        public static void Main(string[] args)
        {
            CountNumber obj1Count = new CountNumber(10);
            Console.WriteLine("After pre increment, the values are");

            CountNumber obj2Count = ++ obj1Count; //Pre-increment 
            Console.WriteLine(obj1Count.a);
            Console.WriteLine(obj2Count.a);
            obj2Count = obj1Count++; //Post-Increment 
            Console.WriteLine("After post increment, the values are");
            Console.WriteLine(obj1Count.a);
            Console.WriteLine(obj2Count.a);
            Console.ReadKey();
        }
    }
}
