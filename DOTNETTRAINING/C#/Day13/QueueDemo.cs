using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program1
{
    internal class QueueDemo
    {
        public static void Main(string[] args)
        {
            //Created and initialize the queue using Enquque()  - FIFO
            Queue myqueue = new Queue();
            myqueue.Enqueue(100);
            myqueue.Enqueue(200);
            myqueue.Enqueue(300);
            myqueue.Enqueue(400);
            myqueue.Enqueue(500);
            myqueue.Enqueue(90);


            Console.WriteLine("after inserting the values");

            foreach (var item in myqueue)
            {
                Console.WriteLine(item);
            }

            //Remove the from the queue using Dequeue()
            myqueue.Dequeue();
            myqueue.Dequeue();
            Console.WriteLine("after removing the values");
            foreach (var item in myqueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Find the first element in the queue");
            Console.WriteLine(myqueue.Peek());
            Console.ReadLine();
        }

    }
}
