using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ArithmeticAssignementOperators
    {
        public static void Main(string[] args)
        {
            //Arithmetic Assignment operators(+=,-=,*=,/=,%=)
            /*
             * += (addition assignment )
             * -= (subtraction assignment)
             * *= (multiplication assignment)
             * /= (division assignment)
             * %= (modulo assignment)
            */
            int num1, num2;

            Console.WriteLine("Enter the number 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The entered number1 is {0}", num1);
            Console.WriteLine("The entered number2 is {0}", num2);

            Console.WriteLine("==============*********=======================");
            Console.WriteLine("==============Addition Assignment=============");


            /*    += (Addition assignment )
             * num1 -= num2 -> means num1 = num1 - num2 
             * num1 = 5, num2 = 4, 
             * num 1 = num 1 - num2 = 5 + 4 = 9, so 
             * num 1 = 9
             * num 1 =9, num 2= 4 
             */

            Console.WriteLine("The number 1 value , \t\t number 2 value \n \t {0} \t\t\t\t{1}; \nafter the addition assignment, new number 1 value is {2} ", num1, num2, num1 += num2);

            Console.WriteLine("==============*********==========================");
            Console.WriteLine("==============Subtraction Assignment=============");

            /*    -= (subtraction assignment )
             * num1 -= num2 -> means num1 = num1 - num2 
             * num1 = 9, num2 = 4, 
             * num 1 = num 1 - num2 = 9 - 4 = 5, so 
             * num 1 = 5
             * num 1 =5, num 2= 4 
             */

            Console.WriteLine("The number 1 value , \t\t number 2 value \n \t {0} \t\t\t\t{1}; \nafter the subtraction assignment, new number 1 value is {2} ", num1, num2, num1 -= num2);

            Console.WriteLine("==============*********=============================");
            Console.WriteLine("==============Multiplication Assignment=============");

            /*    *= (multiplication assignment )
             * num1 += num2 -> means num1 = num1 * num2 
             * num1 = 5, num2 = 4, 
             * num 1 = num 1 * num2 = 5 * 4 = 20, so 
             * num 1 = 20
             * num 1 =20, num 2= 4
             */
            Console.WriteLine("The number 1 value , \t\t number 2 value \n \t {0} \t\t\t\t{1}; \nafter the multiplication assignment, new number 1 value is {2} ", num1, num2, num1 *= num2);

            Console.WriteLine("==============*********=======================");
            Console.WriteLine("==============Division Assignment=============");

            /*    /= (division assignment )
             * num1 /= num2 -> means num1 = num1 / num2 
             * num1 = 20, num2 = 4, 
             * num 1 = num 1 / num2 = 20 / 4 = 5, so 
             * num 1 = 5
             * num 1 =5, num 2= 4
             */
            Console.WriteLine("The number 1 value , \t\t number 2 value \n \t {0} \t\t\t\t{1}; \nafter the division assignment, new number 1 value is {2} ", num1, num2, num1 /= num2);

            Console.WriteLine("==============*********=======================");
            Console.WriteLine("==============Modulo Assignment=============");

            /*    /= (modulo assignment )
            * num1 %= num2 -> means num1 = num1 % num2 
            * num1 = 5, num2 = 4, 
            * num 1 = num 1 % num2 = 5 % 4 = 1, so 
            * num 1 = 1
            * num 1 =1, num 2= 4
            */
            Console.WriteLine("The number 1 value , \t\t number 2 value \n \t {0} \t\t\t\t{1}; \nafter the modulo assignment, new number 1 value is {2} ", num1, num2, num1 %= num2);

            Console.ReadLine();
        }
    }
}