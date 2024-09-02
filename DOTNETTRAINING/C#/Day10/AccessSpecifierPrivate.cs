using Program1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Program1
{
    class car 
    {
        private string make; //The scope of this variable is only within the car class. Because the access specifier is private 
        string modelName; //by default scope is private if we don't write anything
        int maxSpeed; //default access specifier is private
        internal string color;
    }

    class Student //Class name always starts with UPPERCASE letter 
    {
        int studentId;
        string studentName, className;
    }

    class Television
    {
        public string brand; //We can access variable brand in other classes. Why? The access specifier is public 
        private string model; //We can't access in other classes   Why? The access specifier is private 
        int serialNumber, tvSize; // by default the access specifier is private 
    }
    internal class AccessSpecifierPrivate
    {

        public static void Main(string[] args)
        {
            car obj1 = new car();//Instance of a class 
          
            //To access variable or methods of a calss
            //Create an object then use object.variablename or methodname 
            //obj1.modelName ="Audi";  Extension methods cannot access private members of the type they are extending
           
            Student obj2 = new Student();
            //obj2.studentId = "1"; //Inaccessiable due to it's protection level

            Television obj3 = new Television();
            //obj3.tvSize = 64; //tvSize Inaccessiable due to it's protection level
            
            obj3.brand = "LG"; // variable brand can be accessible. Why? This is because it is defined as public 
            Console.WriteLine("The Television brand {0}", obj3.brand);
            
            Console.WriteLine("Learning about the private access specifier");
            
            Console.ReadLine();
        }
    }
}

