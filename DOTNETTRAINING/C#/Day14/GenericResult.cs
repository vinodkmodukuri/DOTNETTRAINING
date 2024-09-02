using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Sum <T>
    {
        public T num1;

    }


    internal class GenericResult
    {
        public static  void Main (string[] args)
        {
            Sum<int> mysum = new Sum<int>();
            mysum.num1 = 10; 
            Console.WriteLine(mysum.num1);

            Sum<string> mystring = new Sum<string>();
            mystring.num1 = "Ram"; 
            Console.WriteLine(mystring.num1);
            Console.ReadLine();
        }
    }
}
