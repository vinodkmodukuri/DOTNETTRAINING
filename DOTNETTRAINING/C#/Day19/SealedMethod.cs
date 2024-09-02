using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class TypesOfTransportation
    {

        public virtual void Move()
        {
            Console.WriteLine("Take or carry people or goods from one place to another place");
        }

        public virtual void mysealedmethod()
        {
            Console.WriteLine("This is a sealed method");
        }
    }
    class AirTransport : TypesOfTransportation
    {
        public override void Move()
        {
            Console.WriteLine("Air transport is flying through the sky");
        }
    }
    class RoadTranport : AirTransport
    {
        public override void Move()
        {
            Console.WriteLine("Road transort is driving on the road");
        }
    }

    class Truck : RoadTranport
    {
        public sealed override void Move()
        {
            Console.WriteLine("Trucks is carying the goods on the road");

        }
    }

    /*    class Bus : Truck
        {
            public override void Move() //'member' : cannot override inherited member 'inherited member' because it is sealed
            {
                Console.WriteLine(" Passengers on the bus");

            }
        }*/

    internal class SealedMethod
    {
        public static void Main(string[] args)
        {
            TypesOfTransportation typesOfTransportation = new TypesOfTransportation();
            AirTransport airTransport = new AirTransport();
            RoadTranport roadTranport = new RoadTranport();
            Truck truck = new Truck();
            typesOfTransportation.Move();
            airTransport.Move();
            roadTranport.Move();
            truck.Move();
            Console.ReadKey(); 
        }
    }
}
