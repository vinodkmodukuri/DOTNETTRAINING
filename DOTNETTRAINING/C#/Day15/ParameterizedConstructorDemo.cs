using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1

{

    internal class ParameterizedConstructorDemo
    {
        public int a,b;
        //public void Initialize();
        ParameterizedConstructorDemo(int test1, int test2) //Parameterized constructor
        {        
           a = test1;
           b = test2;
        }

        public void Display()
        {
            Console.WriteLine("The a value is {0}, and b value is {1}", a, b);

        }
        public static void Main(String[] args)

        {
            int num1, num2;
            Console.WriteLine("Enter two values");
            num1=Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The a value is {0}, and b value is {1}", num1, num2);
            
            ParameterizedConstructorDemo myobj = new ParameterizedConstructorDemo(5, 6);
           //myobj.Initialize();
           myobj.Display();
           Console.WriteLine("The a value is {0}, and b value is {1}", myobj.a, myobj.b); 
           Console.ReadLine();
        }
    }
}
