using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1

{
    internal class DelegateWithTwoParameters
    {
        public delegate void Add(int x, int y);

        public void AddTwoNumbers(int a, int b)
        {
            Console.WriteLine("The sum of two numbers {0}", a + b);
        }

        public static void Main (string[] args)
        {
            DelegateWithTwoParameters myobj = new DelegateWithTwoParameters();

            /*            delegateWithTwoParameters.AddTwoNumbers(2, 5);
            */
            Add delegateAdd = new Add(myobj.AddTwoNumbers);
            delegateAdd(12, 19);

            Console.ReadLine();
        }
    }
}
