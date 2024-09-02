/*
 
How a Constructor and Destructor work in C#?

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


Refer: ConstructorAndDestructor.cs program

===============================

Dynamic polymorphism
----------------------------------
Abstract classes
Virtual functions.


Abstract classes
---------------------------
An abstract class is a special type of class which cannot be instantiated directly instead it serves as a blue print for other classes.

An abstract class contains abstract methods which are the methods declared in the abstract class but must be implemented in derived classes.
In the derived class the abstract method must be overridden.

Abstract methods are the methods which do not have any body.

use the keyword abstract to create an abstract class and abstract method.

syntax:
---------
abstract class abstractclassname
{
public abstract void methodname();
}

class child : abstractclassname
{
public override void methodname()
{
//body
}
}
======================
Virtual Functions
------------------------------
Virtual methods are the methods in a base class that have a default implementation but can be overridden in derived class.

use virtual keyword to declare a method as virtual.
derived classes use the override keyword to provide a specific implementation of the method.
This helps us to understand how a child class can override virtual method of its parent.


syntax:
-----------
class baseclassname
{
public virtual void methodname()
{
//body
}
}

class childclass : baseclassname
{
public override void methodname()
{
//body
}
}


Example: Refer VirtualFunctions.cs
 
 
 */