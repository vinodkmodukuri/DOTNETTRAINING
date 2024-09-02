using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    
    internal class GenericMethod
    {
        public void swap<T> (ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void Main(string[] args)
        {
            GenericMethod myobj = new GenericMethod();
            int x, y;
            Console.WriteLine("Enter the two number"); 
            x = Convert.ToInt32 (Console.ReadLine());
            y= Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Before swapping x value is {0}, y value {1} ", x, y); 

            myobj.swap <int> (ref x, ref y);
            Console.WriteLine("After swapping x value is {0}, y value {1} ", x, y);

            char c = 'A';
            char d = 'B';
            Console.WriteLine("Before swapping x value is {0}, y value {1} ", c, d);
            myobj.swap<char>(ref c, ref d);
            Console.WriteLine("After swapping x value is {0}, y value {1} ", c, d);

            double e = 2.345;
            double f = 0.1234;
            Console.WriteLine("Before swaping e value is {0} and f value is {1}", e, f);
            myobj.swap<double> (ref e, ref f);
            Console.WriteLine("After swaping e value is {0} and f value is {1}", e, f);
            Console.ReadLine();

        }
    }
}
