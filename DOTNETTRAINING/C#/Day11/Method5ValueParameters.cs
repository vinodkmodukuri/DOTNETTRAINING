using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Method5ValueParameters
    {
        public void swap(int a, int b)
        {
            int temp; 
            temp = a; //temp 20
            a = b; //a = 25
            b = temp; //b = 20

        }

        public  static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the a and b values"); 
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swap the values are a={0} b={1}", a, b);

            //After the swap

            Method5ValueParameters obj = new Method5ValueParameters();
            obj.swap(a, b);
            Console.WriteLine("After Swap the values are a={0} b={1}", a, b);
            Console.ReadLine();
        }
    }
}


