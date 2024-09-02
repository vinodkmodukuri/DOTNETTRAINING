using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //Single Inheritance

     class Furniture
    {
        protected string color;
        protected int height;
        protected int width;    

    }

    class BookShelves : Furniture //All the properties and methods are inherited to the child class
    {
        protected int numberOfShelfs;
        public void Accept()
        {
            Console.WriteLine("Enter the color"); 
            color = Console.ReadLine();
            Console.WriteLine("Enter the height"); 
            height=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width");
            width=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of shels");
            numberOfShelfs = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("The color is {0}", color);
            Console.WriteLine("The height is {0}", height);
            Console.WriteLine("The width us {0}", width);
            Console.WriteLine("The number of shels are {0}", numberOfShelfs);
        }

    }

    internal class SingleInheritanceFurniture
    {

        public static void Main(string[] args)
        {
            BookShelves myobj = new BookShelves();
            myobj.Accept();
            myobj.Display();
            Console.ReadLine();
        }
    }

}
