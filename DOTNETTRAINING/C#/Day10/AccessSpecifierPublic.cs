using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{  
    class car1
    {
        private string make; //The scope of this variable is only within the car class 
        string modelName; //default scope is private
        int maxSpeed;
        public string color;
        public int millage;
        internal int year;
    }
    
    internal class AccessSpecifierPublic
    {

        public static void Main(string[] args)
        {
            car1 obj1 = new car1();//Instance of a class 
                                //To access variable or methods of a calss
                                //Create an object then use objec.variablename or methodname 

            //obj1.modelName ="Audi";  //Inaccessiable due to it's protection level
            obj1.color = "Red";
            Console.WriteLine("The car color is {0}", obj1.color);
            obj1.millage = 20;
            Console.WriteLine("The car millage is {0}", obj1.millage);
            Console.WriteLine("Learning about the public access specifier");
            Console.ReadLine();
        }
    }
}
