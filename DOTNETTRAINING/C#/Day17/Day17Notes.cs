/*

Inheritance
--------------
    1) Inheritance allow us to create a new class from an existing class.

    2) The class from which a new class is created is known as base class or parent class or super class.

    3) The new class is known as derived class or child class or sub class .

    4) The derived class inherits the fields and methods of the base class.
   
    5) It helps with code reusability.

    syntax:
    ----------
    <access_specifier> class <baseclassname>
    {
    }
    <access_specifier> class <childclassname> : <baseclassname>
    {   
    }



      1. Single Inheritance
      --------------------------
      a) A single derived class inherits from a single base class.

        A
        |
        B

        Example Program: Refer SingleInheritance.cs in Day17

     2.  Multi Level inheritance
     ------------------------------------
     a) A derived class inherits from a base class and then the same derived class acts as a base class from another class.

        A
        |
        B
        |
        C

        Example Program: Refer MultiLevelInheritance.cs in Day17

    3. Hierarchical inheritance
    -------------------------------------
    a) Multiple derived classes inherit from a single base class.

                   A
	               |
       ---------------------------
      |                           |
      B	                          C

    Example Program: Refer HirarchicalInheritance.cs in Day17

    4. Multiple inheritance
    --------------------------------
    a) A single derived class inherits multiple base classes.
    b) Multiple inheritance is directly not possible with classes.
    c) We use interfaces to implement multiple inheritance.


        A                         B
        |	                      |
         -------------------------
                     |
                     C


    Example Program: Refer MultipleInheritance.cs in Day17
 
 */