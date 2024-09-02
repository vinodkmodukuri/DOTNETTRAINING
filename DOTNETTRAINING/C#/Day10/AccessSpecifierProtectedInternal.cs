using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{ 
    public class CarDemo
    {
        protected internal string modelname;
    }

    public class TruckDemo : CarDemo
    {

    }
    internal class AccessSpecifierProtectedInternal
    {
        public static void Main(string[] args)
        {

            //Here access specifier acting like internal

            CarDemo obj1 = new CarDemo();
            obj1.modelname = "BMW";
            Console.WriteLine("The car model is {0}", obj1.modelname);

            obj1.modelname = "Audi";
            Console.WriteLine("The car model is {0}", obj1.modelname);

            //Here access specifier acting like internal
            TruckDemo obj2 = new TruckDemo();
            obj2.modelname = "TeslaTruck";
            Console.WriteLine("The truck model is {0}", obj2.modelname);

            Console.ReadLine();



        }
    }
}
