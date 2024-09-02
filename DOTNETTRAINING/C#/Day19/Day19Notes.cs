/*
 Sealed class and sealed method
-----------------------------------------------
sealed class
------------------
A
|
B
|
sealed C
|
D (No more inheritance is applicable)

If we do not need a class to be extended (OR) 
If we want to restrict inheritance then we can use sealed class.

Sealed class is the last class in the hierarchy.

Sealed class cannot be an abstract class.

use sealed keyword to make the class as  sealed class.

class Test
{
}
class Test2:Test
{
}
sealed class Test3:Test2
{
}
----------
Sealed method
----------------------
A method can be sealed and in that case the method cannot be overridden.

sealed class Test
{
public sealed void Show()
{
//statements;
}
}
----------------



Interfaces
-----------------
An interface defines the syntactical contract that all the derived classes should follow.

It is a blue print of a class.
It is like an abstract class because all the methods which are declared inside the interface are abstract methods.

It cannot have method body and cannot be instantiated.

It is used to achieve multiple inheritance which is not possible with classes.

use interface keyword to create an interface.

interface contains only the declaration of the methods.
The implementation of the interface methods are done by the class which implements that interface.

Interfaces specify what a class must do .
Interfaces cannot have private members.
By default all the members of the interface are public and abstract.
Interface cannot contain fields /variables.

Example: 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1.Day19
{

    interface Vehicle
    {
        void Start();
        void Stop();
 
    }
    class Car : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("The car will start");
        }

        public void Stop()
        {
            Console.WriteLine("The car will stop");
        }
    }
    internal class InterfaceDemo
    {

        public static void Main(string[] args)
        {
           Car mycar = new Car();

            mycar.Start();
            mycar.Stop();
            Console.ReadKey();
        }
    }
}

Example 2: One interface inheriting another interface 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1.Day19
{

    interface Vehicle
    {
        void Start();
        void Stop();
 
    }

    interface Bus : Vehicle
    {
        void Speed();
        void Mileage();
    }

    
    
    class Car : Bus
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
           Car mycar = new Car();

            mycar.Start();
            mycar.Stop();
            mycar.Speed();
            mycar.Mileage();
            Console.ReadKey();
        }
    }
}


Multiple Inheritance 



    class A
    {

    }

    class B 
    {

    }

    class C : A, B //Multiple inheritance is not possible with classes 
    {

    }


Example 3: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1.Day19
{

    interface Vehicle
    {
        void Start();
        void Stop();
 
    }

    interface Bus
    {
        void Speed();
        void Mileage();
    }

    
    
    class Car : Bus, Vehicle //Multiple inheritance is possible in interface, but it is not possible in classes
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
           Car mycar = new Car();

            mycar.Start();
            mycar.Stop();
            mycar.Speed();
            mycar.Mileage();
            Console.ReadKey();
        }
    }
}




------------
 */