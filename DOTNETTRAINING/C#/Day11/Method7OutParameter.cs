using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{

    internal class Method7OutParameter
    {
        public void Result(int num1, int num2, out int add, out int sub)
        {
            add = num1 + num2;
            sub = num1 - num2;
        }
        public static void Main(string[] args)
        {
            int test1Add, test2Sub;
            Method7OutParameter obj =new Method7OutParameter();
            obj.Result(10, 20, out test1Add, out test2Sub);
            Console.WriteLine("The sum of two number {0}", test1Add);
            Console.WriteLine("The subtraction of two number {0}", test2Sub);


            //Ask the user for input
            int number1, number2, addition, subtraction;

            Console.WriteLine("Enter two number, (num1 and num2)");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            obj.Result(number1, number2, out addition, out subtraction);
            Console.WriteLine("The sum of number 1 and number 2 is {0}", addition);
            Console.WriteLine("The subtraction of number 1 and number 2 is {0} ", subtraction);


            Console.ReadLine();
        }
    }
}
