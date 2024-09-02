using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //The static class contains static methods
    //You can only use static methods within a static class.No instance is needed.
    public static class MathAddition
    {
        public static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }

    public class StaticMethodAddition
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the the two number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = MathAddition.Add(a, b);

            Console.WriteLine("The sum of two numbe {0}", sum);

            Console.ReadLine();
        }
    }
}
