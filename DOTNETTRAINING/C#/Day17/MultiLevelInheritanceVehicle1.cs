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

    class Vehicle1
    {
        protected int id, year, fuelCapacity;
        protected string make, model, color;
    }

    class Car1 : Vehicle1 // //All the properties and methods are inherited to the child class
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

    class Auto: Car1
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
            Console.WriteLine("Enter the Auto milage");
            milage = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Auto transmission ");
            transmission = (Console.ReadLine());
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
            Console.WriteLine("Auto fuel capacity is:  {0}", milage);
            Console.WriteLine("Auto manufacture is: {0}", make);
            Console.WriteLine("Auto model is: {0}", model);
            Console.WriteLine("Auto color is: {0}", color);
            Console.WriteLine("Auto transmission is: {0}", transmission);
            Console.WriteLine("Number of Passengers can travel in Auto is: {0}", numberOPassengers);
            Console.WriteLine("Number of wheels for an Auto is : {0}", numberOfWheels);
        }

    }

    internal class MultiLevelInheritanceVehicle1
    {

        public static void Main(string[] args)
        {
            Auto myauto = new Auto();
            myauto.AutoAccept();
            myauto.AutoDisplay();
            myauto.Accept();
            myauto.Display();
            Console.ReadLine();
        }
    }
}
