using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program1
{

    /*
     a) Multiple derived classes inherit from a single base class.

                       A
                       |
           ---------------------------
          |                           |
          B	                          C



     */

    class Vehicle2 //base class
    {
        protected int id, year, fuelCapacity;
        protected string make, model, color;
    }

    class Car2 : Vehicle2 //All the properties and methods are inherited to the child class
    {
        protected float milage;
        protected string transmission;

        public void Accept()
        {
            Console.WriteLine("Enter the car id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the car year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the car fuel capacity");
            fuelCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the car manufacture");
            make = (Console.ReadLine());
            Console.WriteLine("Enter the car model");
            model = (Console.ReadLine());
            Console.WriteLine("Enter the car color");
            color = (Console.ReadLine());
            Console.WriteLine("Enter the car milage");
            milage = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the car transmission ");
            transmission = (Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Car id is: {0}", id);
            Console.WriteLine("Car manufacture year is: {0}", year);
            Console.WriteLine("Car fuel capacity is:  {0}", milage);
            Console.WriteLine("Car manufacture is: {0}", make);
            Console.WriteLine("Car model is: {0}", model);
            Console.WriteLine("Car color is: {0}", color);
            Console.WriteLine("Car transmission is: {0}", transmission);
        }
    }

    class auto1 : Vehicle2
    {
        protected int numberOPassengers, numberOfWheels;

        public void AutoAccept()
        {

            Console.WriteLine(" Enter the Auto ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Auto year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Auto fuel capacity");
            fuelCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Auto manufacture");
            make = (Console.ReadLine());
            Console.WriteLine("Enter the Auto model");
            model = (Console.ReadLine());
            Console.WriteLine("Enter the Auto color");
            color = (Console.ReadLine());
            Console.WriteLine("Enter the number of passengers");
            numberOPassengers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of wheels");
            numberOfWheels = Convert.ToInt32(Console.ReadLine());
        }

        public void AutoDisplay()
        {
            Console.WriteLine("The Auto ID is : {0}", id);
            Console.WriteLine("Auto id is: {0}", id);
            Console.WriteLine("Auto manufacture year is: {0}", year);
            Console.WriteLine("Auto manufacture is: {0}", make);
            Console.WriteLine("Auto model is: {0}", model);
            Console.WriteLine("Auto color is: {0}", color);
            Console.WriteLine("Number of Passengers can travel in Auto is: {0}", numberOPassengers);
            Console.WriteLine("Number of wheels for an Auto is : {0}", numberOfWheels);
        }

        internal class HierarchicalInheritance
        {
            public static void Main(string[] args) 
            {
                Car2 myCar = new Car2();
                myCar.Accept();
                myCar.Display();

                auto1 myAuto = new auto1();
                myAuto.AutoAccept();
                myAuto.AutoDisplay();
                Console.ReadLine();
            }

        }
    }

}

