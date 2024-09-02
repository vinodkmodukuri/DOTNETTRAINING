using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1

{
    internal class Multicastdelegate
    {
        public delegate void MyAdd(int num1, int num2);
        public void Result(int test1, int test2)
        {
            Console.WriteLine("Addition is {0}", test1 + test2);
        }
        public void Prod(int test1, int test2)
        {
            Console.WriteLine("Product is {0}", test1 * test2);
        }
        public static void Main()
        {

            Multicastdelegate ob1 = new Multicastdelegate();
            MyAdd deladd = new MyAdd(ob1.Result);
            deladd += new MyAdd(ob1.Prod);
            deladd(4, 6);

            Console.ReadLine();

        }

    }
}
