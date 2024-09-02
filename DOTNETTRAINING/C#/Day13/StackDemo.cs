using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program1
{
    internal class StackDemo
    {
        public static void Main(string[] args)
        {
            //Created and initialize the stack usinf Push()  - LIFO
            Stack mystack = new Stack();
            mystack.Push(200);
            mystack.Push(400);
            mystack.Push(600);
            mystack.Push(1000);
            Console.WriteLine("After inserting the values");

            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }

           //Remove the values from the stack using Pop()
            mystack.Pop();
            mystack.Pop();
            Console.WriteLine("fter removing the values");
            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The peek elememt is ");
            Console.WriteLine(mystack.Peek());

            Console.ReadLine();
        }

    }
}
