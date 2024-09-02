using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public delegate void DelegateHello(string message);


    internal class DelegateDemo
    {
        public static void Hello(string message)
        {

             Console.WriteLine("Welcome to {0}",message);   
        }
        public static void Main(string[] args)
        {
            //Calling the method directly with calss name
            DelegateDemo.Hello("C # Programming");

            //Creating an object using the delegate methods
            DelegateHello myDelegateDemo = new DelegateHello(Hello);
            myDelegateDemo("C# Tutorial");

            Console.ReadKey();
        }
    }
}

//Why do we need delegate when we can call the method directly with a calss name?
