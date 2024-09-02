using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1

{
    //Arithmetic Operators (+, -, *, /, %)
    /* + (addition) - Add two numbers
     * - (subtraction) - Subtracts two numbers
     * * (multiplication) - Multiplies two numbers
     * / (division) - Divides one number by another 
     * % (modulo) - Gives the reminder of a division between two numbers 
     */
    internal class ArithmeticOperators
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The addition of number 1 ({0}) and number 2 ({1}) is: {2}", num1 , num2, num1+num2);
            Console.WriteLine("The subtraction of number1 ({0}) and number 2 ({1}) is: {2}", num1, num2, num1 - num2);
            Console.WriteLine("The multiplication of number1 ({0}) and number 2 ({1}) is: {2}", num1, num2, num1 * num2);
            Console.WriteLine("The division of number1 ({0}) and number 2 ({1}) is: {2}", num1, num2, num1 / num2);
            Console.WriteLine("The modulus of number1 ({0}) and number 2 ({1}) is: {2} ", num1, num2, num1 % num2);

            float a, b;
            Console.WriteLine("Enter the first float value");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the secnd float value"); 
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("The sum of two float values {0}", a + b);
            Console.WriteLine("The difference of two float values {0}", a - b);
            Console.WriteLine("The multiplication of two float values {0}", a * b);
            Console.WriteLine("The division of two float values {0}", a / b);
            Console.WriteLine("The modulo of two float values {0}", a % b);
            Console.ReadLine();
        }
    }
}

