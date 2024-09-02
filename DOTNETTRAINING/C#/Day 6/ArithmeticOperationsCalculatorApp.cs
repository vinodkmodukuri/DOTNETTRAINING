using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ArithmeticOperationsCalculatorApp
    {
        public static void Main(string[] args)
        {
            double number1;
            double number2;
            double result;
            string operation;

            Console.WriteLine("\t\t\t\t\tArithmeticOperationsCalculatorApp");
            Console.WriteLine("\t\t\t\t\t=================================");

            Console.WriteLine("Enter the number 1");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\t\t\t\t\tSelect the operator +, -, *, /, and %");
            operation = Console.ReadLine();

            Console.WriteLine("Enter the number 2");
            number2 = Convert.ToDouble(Console.ReadLine());

            if(operation=="+")
            {
                result = number1 + number2;
                Console.WriteLine("\t\t\t\t\tThe sum is: {0}", result);
            }

            if (operation == "-")
            {
                result = number1 - number2;
                Console.WriteLine("T\t\t\t\t\the subtraction is: {0}", result);
            }

            if (operation == "*")
            {
                result = number1 * number2;
                Console.WriteLine("\t\t\t\t\tThe multiplication is: {0}", result);
            }

            if (operation == "/")
            {
                result = number1 / number2;
                Console.WriteLine("\t\t\t\t\tThe division is: {0}", result);
            }

            if (operation == "%")
            {
                result = number1 % number2;
                Console.WriteLine("\t\t\t\t\tThe percentage is: {0}", result);
            }
            Console.ReadKey();

        }

    }
}
