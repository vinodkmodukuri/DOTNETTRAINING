using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program1
{
    internal class ArrayListDemo
    {
        public static void Main(string[] args)
        {
            //Add() method 
            ArrayList myArraylist = new ArrayList();
            myArraylist.Add(1);
            myArraylist.Add('A');
            myArraylist.Add("This is the Array List");
            myArraylist.Add(0.234);
            Console.WriteLine("The values in the Array list");
            foreach (var item in myArraylist)
            {
                Console.WriteLine(item);
            }

            //Remove() method
            myArraylist.Remove('A');
            myArraylist.Remove("This is the Array List");
            myArraylist.Remove(0.234);
            Console.WriteLine("After removing the vlues are");
            foreach (var item in myArraylist)
            {
                Console.WriteLine(item);
            }

            //Insert() method 
            myArraylist.Insert(1, 24);
            Console.WriteLine("After inserting the values are");
            foreach (var item in myArraylist)
            {
                Console.WriteLine(item);
            }
            myArraylist.Insert(2, 3500);
            Console.WriteLine("After inserting the values are");
            foreach (var item in myArraylist)
            {
                Console.WriteLine(item);
            }
            myArraylist.Insert(3, 445);
            Console.WriteLine("After inserting the values are");
            foreach (var item in myArraylist)
            {
                Console.WriteLine(item);
            }

            //Sort() method 
            myArraylist.Sort();
            Console.WriteLine("After sorting the values are");
            foreach (var item in myArraylist)
            {
                Console.WriteLine(item);
            }

            //Reverse() method 
            myArraylist.Reverse();
            Console.WriteLine("After reversing, the values are");
            foreach (var item in myArraylist)
            {
                Console.WriteLine(item);
            }
            myArraylist.Clear();
            Console.WriteLine("After clearing, the values are");
            foreach (var item in myArraylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

