/*
 
==============


Abstraction and Encapsulation
---------------------------------------------
Abstraction

Car
------
A -  Model
B - Mileage
C - Speed

What is abstraction?
--------------------

Abstraction means looking for what we want. 
Data abstraction is the process of hiding certain details and showing only essential information to the user

How to achieve abstraction?
---------------------------
Abstraction can be achieved with either Astract class (Day 18) or Interface (Day 19)


What is encapsulation?
------------------------

Encapsulation hiding the details (data-hiding) or binding together the data.
Encapsulation is defined as the wrapping up of data and information under a single unit.
It is the mechanism that binds together the data and the functions that manipulate them. 

How to achieve encapsulation?
-------------------------------
Encapsulation can be implemented by using Access Specifiers


What is Access Specifier?
-------------------------
Access Specifier defines the scope of a class member. (Scope means - Some extent) 

A class member can be a variable or a method.
A program can have more than one class.
I want some members of a class (variable or method) to be accessible to other classes.
I don't want members of class to (variable or method) be accessible outside the class.

Example: 
Class A { int x}
Calss B { }
I want to access varible (int x) with in the class A only not in B 
                        OR
I want to access varible (int x) in the class B also, so we should do the scope means use the access specifier

Types of Access Specifiers
---------------------------
1. private
2. public
3. protected
4. internal
5. protected internal



1.private
-----------
It allows a class to hide its member variables and member functions from other class objects.
private members of a class is not visible outside the class.
If a member is declared as private then only the functions/methods of that class only can access the members.
When we don't specify any data member as private, public, protected then the default access specifier for a data member is private.


Example Program: 

  class Car
    {
        private string modelname; // access specifier is private - The scope is with in the Car class
        int maxspeed;  //default access specifier is private     
    }
    internal class PrivateAccessdemo
    {
        public static void Main()
        {
            Car objcar = new Car(); //instance of a class or creating an object
            //objcar.modelname = "BMW"; //inaccessible due to its protection level
            Console.ReadKey();
        }
    }

Example: Refer AccessSpecifierPrivate.cs

-----------------------------------------


2. public
----------
It allows a class to expose its member variables and member functions to other classes and functions.

 class Car
    {
        public string color;
    }
    internal class PublicAccessdemo
    {
        public static void Main()
        {
            Car objcar = new Car(); //instance of a class or creating an object
                       
            //to access variables or methods of a class. create an object and
            //after that use object.variablename or methodname.

            objcar.color = "blue";
            Console.WriteLine("color is {0}",objcar.color);
            Console.ReadKey();
        }
    }

Reference: AccessSpecifierPublic
------------------------------------


3.protected
------------
It allows a class to hide its member variables and member functions from other classes except child class.
It is important while using inheritance.
It is similar like private but it can be accessible to child classes.


 class Car
    {
        protected int mileage;
    }
    internal class ProtectedAccessdemo : Car
    {

        public static void Main()
        {
            //to access variables or methods of a class. create an object and
            //after that use object.variablename or methodname.

            PrivateAccessdemo ob1 = new PrivateAccessdemo();
            ob1.mileage = 18;

            Console.WriteLine("mileage is {0}",ob1.mileage);
            Console.ReadKey();
        }
    }

Reference - AccessSpecifierProtected.cs

------------------

internal
------------
It allows a class to expose its members to other classes and objects within in the same namespace.

Any member which is declared as internal can be accessed from any class or method which is defined within the application/namespace in which the member is defined.


When we do not specify any access specifier for a class like private, public, protected, internal  then by default the class is internal.


  class Car
    {
        internal int year;
    }
  

internal class Program
    {
      public  static void Main(string[] args)
        {
            Car ob1 = new Car();
            ob1.year = 2021;
            Console.WriteLine("Manufacturing year is {0}",ob1.year);
            Console.ReadKey();
        }
    }

-------------------

5.protected internal
--------------------
It allows a class to hide its members to be accessed from other class objects except child class.


acting like internal

 class Cardemo
    {
        protected internal string modelname;
    }
    internal class Protectedinternaldemo
    {
        public static void Main()
        {
            Cardemo ob1 = new Cardemo();
            ob1.modelname = "AUDI25";
            Console.WriteLine("model name is {0}",ob1.modelname);

            Console.ReadKey();
        }
    }
--------------------

acting like protected

class Cardemo
    {
        protected internal string modelname;
    }
    internal class Protectedinternaldemo : Cardemo
    {
        public static void Main()
        {
            Protectedinternaldemo ob2 = new Protectedinternaldemo();
            ob2.modelname = "BMW";
            Console.WriteLine("Model name is {0}",ob2.modelname);
            Console.ReadKey();
        }
    }
----------------
How to access varibles and method across projects?


namespace ConsoleAppDemo
{
  public class Cardemo
    {
        protected internal string modelname;
    }
}

Right click on the Solution in solution explorer -> Add new project -> C# Console app (.Net framework) 

After creating new project, right click on solution explorer, go to references, add reference and select projects and add your previous project name / namespace name.

after that type
using oldnamespacename;

use inheritance in the new project/namespace



using ConsoleAppDemo;

namespace ConsoleAppExamples
{
    internal class Program : Cardemo
    {
    public  static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.modelname = "Suzuki";
            Console.WriteLine("Model name is {0}", p1.modelname);
            Console.ReadKey();
        }
    }
}
Reference: AccessSpecifierProtectedInternal

 */