using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1

{

    internal class ConstructorDemo
    {
        int a;
        int b;
        //public void Initialize();
        ConstructorDemo() //default constructor
        {        
           a = 10;
           b = 50;
        }

        public void Display()
        {
            Console.WriteLine("The a value is {0}, and b value is {1}", a, b);

        }
        public static void Main(String[] args)
        {
           ConstructorDemo myobj = new ConstructorDemo();
           //myobj.Initialize();
           myobj.Display();
           Console.WriteLine("The a value is {0}, and b value is {1}", myobj.a, myobj.b); 
           Console.ReadLine();
        }
    }
}
