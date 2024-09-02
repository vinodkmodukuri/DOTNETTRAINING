using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class ParentA
    {
        public ParentA() {

            Console.WriteLine("This is the parent class");

        }
        ~ ParentA(){
            Console.WriteLine("This is a destructor for a parent class");
        }

    }

    class ChildB : ParentA
    {
        public ChildB()
        {
            Console.WriteLine("This is a child class B"); 
        }

        ~ChildB()
        {
            Console.WriteLine("This is a destructor for a child class");
        }
    }
    internal class ConstructorAndDestructor
    {
        public static void Main(string[] args)
        {
            ChildB myobj = new ChildB();
            Console.ReadKey();

        }
    }
}

/*Order of Constructors and Destructors in inheritance
-----------------------------------------------------------------------------
A class
----------
A() - A class constructor
~A() - A class destructor

B Class inherited from A class
---------------------------------------------
B() - B class constructor
~B() - B class destructor



Constructors are executed from top to bottom (base to derived)
Destructors are executed from bottom to top (derived to base).

This is the order of invoking the constructors and destructors.
 */