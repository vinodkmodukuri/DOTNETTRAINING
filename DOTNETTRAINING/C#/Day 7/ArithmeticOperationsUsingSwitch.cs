using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ArithmeticOperationsUsingSwith
    { 
        //Write a program to accept two numbers and one arithmetic operator (+,-,*,/,%) and based on arithmetic operator display the result.
        public static void Main(string[] args)
        {
            int number1, number2;
            char value;
            Console.WriteLine("Enter the number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Operator either +, -, *, / and %");
            value = Convert.ToChar(Console.ReadLine());
            switch (value)
            {
                case '+':
                    Console.WriteLine("Sum of number 1 and number 2  number {0}", number1 + number2);
                    break;
                case '-':
                    Console.WriteLine("Subtraction of two number {0}", number1 - number2);
                    break;
                case '*':
                    Console.WriteLine("Multiplication of two number {0}", number1 * number2);
                    break;

                case '/':
                    Console.WriteLine("Division of two number {0}", number1 / number2);
                    break;
                case '%':
                    Console.WriteLine("Modulo of two number {0}", number1 % number2);
                    break;
                default:
                    Console.WriteLine("Enter the correct operator");
                    break;
            }
            Console.ReadLine();
        }
    }
}

    /*switch(expression)
{
case constantexpressin1:
//statements;
break;
case constantexpression2:
//statements;
break;
case constantexpression3:
//statements;
break;
....
...
...
default:
//statements;
break;
}
     */