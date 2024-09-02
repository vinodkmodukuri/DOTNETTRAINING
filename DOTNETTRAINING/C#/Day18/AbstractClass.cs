using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //Define an abstract class 'FurnitureDemo'
    abstract class FurnitureDemo
    {
        //Protected fields shared by the derived class 
        protected string color;
        protected float height, width;

        //Abstract methods that must be implemented by derived class 
        public abstract void Accept();
        public abstract void Display();
    }

    //Derived class 'Chair' that inherits 'FurnitureDemo'

    class Chair : FurnitureDemo
    {
        //Created aditional field specific to 'Chair' class 
        protected int numberOfLegs;

        //Implement the 'Accept' method 
        public override void Accept()
        {
            Console.WriteLine("Enter the color of the Furniture");
            color = Console.ReadLine();
            Console.WriteLine("Enter the Width");
            width =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the height");
            height =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the number of legs");
            numberOfLegs = Convert.ToInt32(Console.ReadLine());
        }

        //Implement the 'Display' method 

        public override void Display()
        {
            Console.WriteLine("The chair color is {0}", color);
            Console.WriteLine("The chair height is {0}", height);
            Console.WriteLine("The chair width is {0}", width);
            Console.WriteLine("The number legs for a chair{0}", numberOfLegs);
        }
    }

    internal class AbstractClass
    {

        public static void Main(string[] args)
        {
            //Create an instance for the Chair class 
            Chair mychair = new Chair(); 
            
            //call the methods
            mychair.Accept();
            mychair.Display();
           
            Console.ReadKey();
        }
    }
}

