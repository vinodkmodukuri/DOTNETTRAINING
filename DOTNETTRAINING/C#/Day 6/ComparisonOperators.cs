using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ComparisonOperators
    {
        public static void Main(string[] args)
        {
            //=========Comparison Operators===========
            //> , < , >= , <= , == , and !== .

            int number1;
            int number2;
            Console.WriteLine("Enter the number 1");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            number2=Convert.ToInt32(Console.ReadLine());

            // (>) Greater than 
            Console.WriteLine("=============== \">\" Greater than==============");
            Console.WriteLine("is {0} greater than {1}?: {2}", number1, number2, number1>number2);

            
            // (<) Less than
            
            Console.WriteLine("=============== \"<\" Less than==============");
            Console.WriteLine("is {0} Less than {1}?:{2}", number1, number2, number1<number2);

            // (>=) Greater than or Equal to 
            Console.WriteLine("=============== \">=\" Greater than or Equal to==============");
            Console.WriteLine("is {0} greater than or eaual to {1}?: {2}", number1, number2, number1>=number2);

            // (<=) Less than or Equal to
            Console.WriteLine("=============== \"<=\" Less than or equal to==============");
            Console.WriteLine("is {0} less than or equal to {1}?: {2}", number1, number2, number1<=number2);

            // (==) Equal to
            Console.WriteLine("=============== \"==\" Equal to==============");
            Console.WriteLine("is {0} equal to {1}?: {2}", number1, number2, number1==number2);

           // (!=) Not Equal to

            Console.WriteLine("=============== \"!==\" Not Equal to==============");
            Console.WriteLine("is {0} not equal to {1}?: {2}", number1, number2, number1 != number2);


            Console.ReadKey();
        }
    }
}
