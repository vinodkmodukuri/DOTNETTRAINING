using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class FunctionOverloading
    {
        public void  Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public void  Add(double c, double d)
        {
            double f = c + d;
            Console.WriteLine(f);
           
        }
        public static void Main(string[] args)
        {
            FunctionOverloading myobj = new FunctionOverloading();
            myobj.Add(20, 40);
            myobj.Add(1.23, 2.345);
            Console.ReadKey();
        }
    }
}
