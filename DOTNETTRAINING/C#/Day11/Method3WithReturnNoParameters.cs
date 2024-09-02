using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Method3NoReturnWithParameters
    {
        //3. Method with return type and no parameters 
        //use the return keyword
        public int Add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            return c;
        }
        public static void Main(string[] args)
        {
            Method3NoReturnWithParameters obj = new Method3NoReturnWithParameters();
            
            // Call the method and store the result
            int result = obj.Add();
            Console.WriteLine("The sum is {0}", result);
            
            // Call the method again directly in the Console.WriteLine
            Console.WriteLine("The sum is {0}", obj.Add());
        }
    }
}