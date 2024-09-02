/*
 
 Methods
------------
A method is a set of one or more program statements which can be executed by referring to the method name.

To use methods
------------------------
Define methods
Call methods

Define methods
------------------------
It means declaring elements of its structure.

syntax:
------------
<access_specifier><return_type><method_name>(with or without parameters)
{
//method body
}


Call methods
---------------------
After defining the methods we can call it by using the name of the method.
Method name is followed by paranthesis even if the method call has no parameters.

methodname();


Categories of methods
----------------------------------
1. Method with no return type and with no parameters.
2. Method with no return type and with parameters.
3. Method with return type and with no parameters.
4. Method with return type and with parameters.


1. Method with no return type and with no parameters.
 internal class Method1
    {
        //Method with no return type and with no parameters.
        //void means which does not return any value.
        public void Add()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = num1 + num2;
            Console.WriteLine("Total is {0}",num3);
        }
        public static void Main()
        {
            Method1 ob1 = new Method1();
            ob1.Add();
           
            Console.ReadKey();
        }
    }
--------------------

2. Method with no return type and with parameters.

internal class Method2
    {
        //2. Method with no return type and with parameters.

        public void Add2(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine("Sum is {0}",num3);
        }
    public static void Main()
        {
            Method2 ob2 = new Method2();
            ob2.Add2(12, 34);
            int t1, t2;
            Console.WriteLine("Enter two numbers");
            t1 = Convert.ToInt32(Console.ReadLine());
            t2 = Convert.ToInt32(Console.ReadLine());

            ob2.Add2(t1, t2);


            Console.ReadKey();
        }
    }
----------------

3. Method with return type and with no parameters.
 internal class Method3
    {
        //3. Method with return type and with no parameters.

        public int Add3()
        {
            int num1 = 15;
            int num2 = 56;
            int num3 = num1 + num2;
            return num3 ;
         }
        public static void Main()
        {
            Method3 ob3 = new Method3();
            
            //First way
             int result= ob3.Add3();
            Console.WriteLine("total is {0}",result);
           
            //second way
            Console.WriteLine("Result is {0}",ob3.Add3());

            Console.ReadKey();
        }
    }
-----------------

4. Method with return type and with parameters.

  internal class Method4
    {
        //4. Method with return type and with parameters.
    
        public int Add4(int num1, int num2)
        {
            int num3 = num1 + num2;
            return num3;
        }
           public static void Main()
        {
            Method4 ob4 = new Method4();
            Console.WriteLine(ob4.Add4(14,12));
            Console.ReadLine();
        }
    }
---------------------

How to use methods with parameters?

declare method with parameters
each parameter has a type and a name.
public void methodname(datatype variablename,datatype variablename,...)
{
//statements;
}


Calling methods with parameters
------------------------------------------------
When a method with a parameter is called we must pass the parameters to the method.

1. Value
2. Reference
3. Output

1. Value
-------------
We call it as in parameters. 
The data can be transferred into the method but cannot be transferred out.


   internal class Swapdemo
    {
        public void Swap(int num1, int num2)
        {
            int temp;
            temp = num1;  //temp=10
            num1 = num2;  //num1=20
            num2 = temp; // num2=10
        }
        public static void Main()
        {

            int test1, test2;
            Console.WriteLine("Enter two numbers");
            test1 = Convert.ToInt32(Console.ReadLine());
            test2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping test1={0} test2={1}",test1,test2);

            Swapdemo ob1 = new Swapdemo();
            ob1.Swap(test1, test2);
            Console.WriteLine("After swapping test1={0} test2={1}", test1, test2);

            Console.ReadKey();
        }
    }

--------------------

2. Reference
--------------------
These are known as in/out parameters.
The data can be transferred into the method and can be transferred out of the method.

use ref keyword.

   internal class Swapdemo
    {
        public void Swap(ref int num1,ref int num2)
        {
            int temp;
            temp = num1;  //temp=10
            num1 = num2;  //num1=20
            num2 = temp; // num2=10
        }
        public static void Main()
        {

            int test1, test2;
            Console.WriteLine("Enter two numbers");
            test1 = Convert.ToInt32(Console.ReadLine());
            test2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping test1={0} test2={1}",test1,test2);

            Swapdemo ob1 = new Swapdemo();
            ob1.Swap(ref test1,ref test2);
            Console.WriteLine("After swapping test1={0} test2={1}", test1, test2);

            Console.ReadKey();
        }
    }

------------------
3. Output
---------------
These are known as out parameters.
Data can be transferred out of the method.
use out keyword.

  internal class Outdemo
    {
        public void Result(int num1, int num2,out int add,out int prod)
        {
            add= num1 + num2;
            prod = num1 * num2;
           
        }
        
        public static void Main()
        {
            int test1add, test2prod;
            Outdemo ob1 = new Outdemo();
            ob1.Result(10, 20, out test1add, out test2prod);
            Console.WriteLine("Total is {0}",test1add);
            Console.WriteLine("Multiplication is {0}",test2prod);
            Console.ReadKey();
        }
    }

--------------------
Static variables and static methods
-----------------------------------------------------
If we want to retain its value throughout the program we can declare the variable as static.

Only one instance of a static variable exists for a class.

declare a static variable using the keyword static.

Student 
------------
stdid
sname
course

s1          	  s2               s3
stdid	          stdid	          stdid
sname	          sname           sname
course	          course          course



Student - If we declare stdid as static 
------------
static stdid
sname
course



		        stdid
		         /|\
s1          	  s2               s3

sname	sname     sname
course	course     course


Static variables can be accessed by using classname.variablename
No need to create any object to access static variables.


  internal class StaticVariabledemo
    {
        public static int num1;
        public static void Main()
        {

            StaticVariabledemo.num1 = 98;
            Console.WriteLine("static variable value is {0}",StaticVariabledemo.num1);
            Console.ReadLine();
        }
    }
------------
Static functions
-------------------------
we can declare a static function using the keyword static
static functions can access only static variables.
Non-static functions can access static and non-static variables.

  internal class StaticFunctionsdemo
    {
        public static int num1;  //static
        public int num2; //non-static

        public void Count() //non-static
        {
            num1++;
        }

        public static int Display() //static
        {
            return num1;
        }


        public static void Main()
        {
            StaticFunctionsdemo ob1 = new StaticFunctionsdemo();
            ob1.Count();
            ob1.Count();
            ob1.Count();
           int result= StaticFunctionsdemo.Display();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

---------------------

 

/*
 
-----------------------------------------
Static variables and non-static variables 
------------------------------------------

                 Static Variables                                    Non-Static Variables 

Declaration:     Declared with the static keyword.	                 Declared without the static keyword.

Access	         Accessible directly through the class name.	     Accessible only through an instance of the class.

Usage            Shared across all instances of the class.	         Each instance of the class has its own copy.

Initialization	 Initialized once and shared across all instances.	 Initialized separately for each instance.

Modification     Changes affect all instances.	                     Changes affect only the instance on which the modification was made.

Example	         public static int count;	                         public int count;

------------------------------------------
Static methods and non-static methods 
------------------------------------------


                 Static Methods                                      Non-Static Methods 

Declaration:     Declared with the static keyword.	                 Declared without the static keyword.

Access	         Can be called directly on the class itself          Must be called on an instance of the class.
                 without needing an instance	     

Usage            Can only access static variables and other          Can access both static and non-static variables
                 static methods.	                                 and methods.

Initialization	 Initialized once and shared across all instances.	 Initialized separately for each instance.

Return values    Can return values, but cannot modify                Can return values and modify instance-specific data.
                 instance-specific dats              

Example	         public static void PrintMessage()                    public void PrintMessage() 
                 {                                                     {
                   Console.WriteLine("Static method");                     Console.WriteLine("Non-static method");
                 }                                                     }

Definition: In C#,  a static method ( or function) is a method that is declared with the static keyword
Access: They can only access static variables and other static methods directly 

Non-Static Methods:
Non-static methods (or instance methods) are methods that do not have a static keyword 
Access : Non-static methods can access both static and non-static (instance) variables and methods.


------------------------------------------
Static classes and non-static classes 
------------------------------------------


                 Static class                                        Non-Static class 

Declaration      Declared with the static keyword.	                 Declared without the static keyword.

Instantiation	 Cannot be instantiated                              Can be instantiated using the new keyword. 
                  	     

Member           Can only contain static members                     Can contain both static and non-static members
                 (methods, variables, properties, etc.).	                                  

Inheritance	     Cannot be inherited	                             Can be inherited (unless explicitly declared as sealed

Return values    Can return values, but cannot modify                Can return values and modify instance-specific data.
                 instance-specific dats              

Example	         public static call Utility                          public class MyClass 
                 {                                                     {
                   public static void HelperMethod()                     public void InstanceMethod()
                   {                                                        {
                    .....                                                     ........
                   }                                                         }
                 }                                                       public static void StaticMethod()
                                                                            {
                                                                              .....
                                                                             }
                                                                        }




 */