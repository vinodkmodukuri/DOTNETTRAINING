using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class ExceptionHaldling
    {
        public void Divide(int a, int b)
        {
            try
            {
                int c = a / b;
                Console.WriteLine("The resule is {0}", c);
            }
            catch (Exception Exp)
            {
                Console.WriteLine("The exception is {0}", Exp.Message);
            }
        }
        public static void Main(string[] args)
        {
            ExceptionHaldling myobj = new ExceptionHaldling();
            myobj.Divide(200, 100); 
            myobj.Divide(200, 0); //Divide by zero exception is handelled with try and catch block

            Console.ReadLine();
        }
    }
}
