using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Method1NoReturnNoParameters //Non-static class 
    {
        //1. Method with no return type and with no parameters 

        //void means - no return type 
        public void Add() //non-static method 
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            Console.WriteLine("The sum of two numbers is {0}", c);
        }
        public static void Main(string[] args)
        {
            //Create an instance of the class
            Method1NoReturnNoParameters obj = new Method1NoReturnNoParameters();

            //call the method 
            obj.Add();

            //Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}