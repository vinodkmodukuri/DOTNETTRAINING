using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{

    //Create a vehicle class and inherit the specifications and create a child class like Car, Bus, Bike

    class  Vehicle
    {
        protected int id, year, fuelCapacity;
        protected string make, model, color;
    }

    class Car : Vehicle // //All the properties and methods are inherited to the child class
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
            milage = Convert.ToSingle (Console.ReadLine());
            Console.WriteLine("Enter the car transmission ");
            transmission = (Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Car id is: {0}", id);
            Console.WriteLine("Car manufacture year is: {0}", year);
            Console.WriteLine("Car fuel capacity is:  {0}", milage);
            Console.WriteLine("Car manufacture is: {0}", make);
            Console.WriteLine("Car mode is: {0}", model);
            Console.WriteLine("Car color is: {0}", color);
            Console.WriteLine("Car transmission is: {0}", transmission);
        }
    }

    internal class SingleInheritanceVehicle
    {

        public static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.Accept();
            mycar.Display();
            Console.ReadLine();
        }
    }
}
