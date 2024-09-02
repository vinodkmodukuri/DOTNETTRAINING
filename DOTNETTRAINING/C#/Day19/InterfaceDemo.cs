using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{

    interface Vehicle3
    {
        void Start();
        void Stop();
 
    }

    interface Bus
    {
        void Speed();
        void Mileage();
    }

    
    
    class Car4 : Bus, Vehicle3 //Multiple inheritance is possible in interface, but it is not possible in classes
    {
        public void Start()
        {
            Console.WriteLine("The car will start");
        }

        public void Stop()
        {
            Console.WriteLine("The car will stop");
        }

        public void Speed()
        {
            Console.WriteLine("The max speed is 50");
        }

        public void Mileage()
        {
            Console.WriteLine("The milage is 20 kmpl");
        }
    }



    internal class InterfaceDemo
    {

        public static void Main(string[] args)
        {
           Car4 mycar = new Car4();

            mycar.Start();
            mycar.Stop();
            mycar.Speed();
            mycar.Mileage();
            Console.ReadKey();
        }


    }
/*    class A
    {

    }

    class B 
    {

    }

    class C : A, B
    {

    }*/
}
