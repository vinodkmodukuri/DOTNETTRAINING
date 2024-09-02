using Program1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class VehicleProtected
    {
        private string make; //Not visible outside the class
        string modelName; //default is private, this is not visible outside the calss
        int maxSpeed; 
        public string color; //Accessible from outside the class 
        protected int mileage; //Accessible with in the calss and derived calsses
    }
    internal class AccessSpecifierProtected : VehicleProtected  //use : and class name to make the class as child class 
    {      
        public static void Main(string[] args)
        {
            //Instance of a child class
            //To access variable or methods of a calss
            //Create an object then use objec.variablename or methodname 

            AccessSpecifierProtected obj1 = new AccessSpecifierProtected();
                                                                        
            //obj1.modelName ="Audi";  //Inaccessiable due to it's protection level
           
            obj1.color = "Red";
            Console.WriteLine("The car color is {0}", obj1.color);
            
            obj1.mileage = 20;
            Console.WriteLine("It can travel up to {0} miles per gallon", obj1.mileage);

            Console.ReadLine();
        }
    }
}

