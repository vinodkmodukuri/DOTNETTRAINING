
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{

    //Uses a non-static method in a non-static class.
    //Requires creating an instance of the class.
    public class MathAdditionNonStaticMethod  //non-static class can have both static and non-static methods. 
    {
        public int Add(int a, int b) //non-static method 
        {
            int c = a + b;
            return c;
        }
    }
    internal class NonStaticMethodAddition
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the the two number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            MathAdditionNonStaticMethod myobj = new MathAdditionNonStaticMethod();
            int sum = myobj.Add(a, b);
            Console.WriteLine("The sum is {0}",sum);
            Console.ReadKey();
        }

    }
}
