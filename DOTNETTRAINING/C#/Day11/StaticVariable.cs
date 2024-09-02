using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //Static variables 
    internal class StaticVariable
    {
        public static int num1, num2, num3;

        public static void Main(string[] args)
        {
            //Initialize static variables 
            StaticVariable.num1 = 100;
            StaticVariable.num2 = 200;
            StaticVariable.num3 = num1 + num2;
            Console.WriteLine("The sum is {0}", StaticVariable.num3);

            StaticVariable.num3 = num1- num2;
            Console.WriteLine("The sum is {0}", StaticVariable.num3);

            Console.ReadLine();
        }
    }
}
