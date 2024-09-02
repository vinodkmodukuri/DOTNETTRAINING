using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class StaticFunctions
    {

        //Staric variab;e 
        public static int num1;

        //Non-static variable 
        public int num2;

        //Non-static method
        public void Count()  
        {
            num1++;
        }

        //Static method

        public static int Display() 
        {
            return num1;
        }

        public static void Main(string[] args)
        {
            //How to access non-static method, create an object to access non-static method
            StaticFunctions obj = new StaticFunctions();
            obj.Count(); 
            obj.Count();
            obj.Count();

            //For static methods, no need to create an object, Access directly using the class name
            int result = StaticFunctions.Display();
            Console.WriteLine("The result is {0}", result);
            Console.ReadLine();
        }
    }
}
