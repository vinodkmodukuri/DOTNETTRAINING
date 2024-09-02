using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //It allows a class to expose its members to other classes and objects within in the same namespace.
    //Any member which is declared as internal can be accessed from any class or method which is defined within the application/namespace in which the member is defined.
    //When we do not specify any access specifier for a class like private, public, protected, internal  then by default the class is internal.

    public class HouseDemo
    {
        internal string modelname;
    }
    internal class AccessSpecifierInternal : HouseDemo
    {

        public static void Main(string[] args)
        {
            HouseDemo obj1 = new HouseDemo();
            obj1.modelname = "Mediterranean";
            Console.WriteLine("The house model is {0}", obj1.modelname);

            //To access internal variables, here we are accessing car class in AccessSpecifierPrivate.cs program from the namespace Program 1
            car mycar = new car();
            mycar.color = "white";
            Console.WriteLine("The mediterranean house color is {0}", mycar.color);
            Console.ReadLine();

        }
    }
}

