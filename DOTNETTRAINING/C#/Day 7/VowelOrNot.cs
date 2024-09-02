using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program1
{
    internal class VowelOrNot
    {
        //Write a program to accept a character and display whether the character is vowel or not.
        //vowel - a, e, i, o, u or A, E, I , O and U 
        
    
        public static void Main(string[] args)
        {
            char alphabet;
            Console.WriteLine("Enter an alphabet between A to Z");
            alphabet = Convert.ToChar(Console.ReadLine());
            switch (alphabet)
            {

                case 'a': Console.WriteLine("Entered charater a vowel");
                    break;

                case 'e':
                    Console.WriteLine("Entered charater is a vowel");
                    break;

                case 'i':
                    Console.WriteLine("Entered charater is a vowel");
                    break;

                case 'o':
                    Console.WriteLine("Entered charater is a vowel");
                    break;

                case 'u':
                    Console.WriteLine("Entered charater is a vowel");
                    break;

                case 'A':
                    Console.WriteLine("Entered charater is a vowel");
                    break;

                case 'E':
                    Console.WriteLine("Entered charater is a vowel");
                    break;

                case 'I':
                    Console.WriteLine("Entered charater is a vowel");
                    break;

                case 'O':
                    Console.WriteLine("Entered charater is a vowel");
                    break;

                case 'U':
                    Console.WriteLine("Entered charater is a vowel");
                    break;

                default: Console.WriteLine("Entered value {0} is not a vowel", alphabet);
                    break;

            }
         Console.ReadLine();
        }
    }
}
