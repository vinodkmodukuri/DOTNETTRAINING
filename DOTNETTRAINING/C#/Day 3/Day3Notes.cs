/*S
STRUCTURE OF C# PROGRAM   
-----------------------
 * How the C# program look like? 
 
        namespace
        class classname
        {
               public static void Main(string [] args) 
                {
                    //statements;
                }
        }

* Explanation   
    1. classname can be either camel case or pascal case.
    2. Console.WriteLine() - It is used to display information.
    3. Console is a class which is present is system namespace.
    4. WriteLine() is a method of Console Class.
    5. It is present in System namespace.
    6. Understand the public, static, void Main, string[] args -  In the subsequest concepts 
    7. [] - Means Array 


* Reference
    1. Check the Welcome.cs 
    2. save the file as Welcome.cs
        eg: Welcome.cs
    3.  Main() is the entry point.  Program execution starts from Main method. in Main()  , M should be in upper case.

* To make the console wait
    1. When we execute the program it will display the output and closes.
    2. Tt will not wait until we read.
    3. To make it wait until unless we press any key
    4.use Console.ReadLine() or Console.ReadKey();
    5. Second way is go to debug menu and select start without debugging output will wait.

*   C# is purely case sensitive.
    eg: HELLO and hello both are different.
*   We can create an executable (.exe) file or dynamic link library (.dll ) file.
=====================================
ESCAPE SEQUENCE CHARACTERS
--------------------------
\n - New Line
\t - Tab
\' - Single quotations
\" - Double quotations
\\ - Single slash
 * Refer EscapeSequences.cs program 
=====================================

What ia  Variable?
------------------
A variable is a location in the memory which has a name and contains a value.
A variable is associated with a data type which defines the type of data which can be stored in a variable.

What is the naming conventions for a variable?
----------------------------------------------
It must begin with a letter or underscore (_)
First letter of variable name cannot be a digit.

Example:
    Firstname
    _lastname
    8num (wrong)

===================================== 
What are the datatypes in C#
----------------------------
Data types in C#
----------------------------
char - 2 bytes of memory
int   - 4 bytes of memory
float - 4 bytes of memory
double - 8 bytes of memory
string - variable length
bool - 1 byte of memory

What are the Types of Data Types in C#?
---------------------------------------
1. Value Types
	--which directly contains value or data.
eg: int, char, float, double


2. Reference Types
* It does not maintain data but they contain a reference to variables which are stored in the memory, also know as heap. 
* Reference types include Ojects, Classes, Interfaces, Delegates, and Arrays. 
* These types store references to the actual data, unlike value types which store the actual data.
* When you assign a reference type to another variable, the address is copied, not the actual data itself. 
* Both variables then point to the same memory location -- changes made through one variable are reflected in the other.
* 
Example: 
var a = new Student();
var b = a;

In the above example, both variables a and b will point to the same student object in memory. 
If we change a, we will also change b. 
This is because a and b are not storing the data but a reference to the location where the data is stored.


How to initialize a variable with a data type?
----------------------------------------------
syntax:
------------
<datatype><variablename>=<value>;
eg:
    int num1 = 45;
    char ch1 = 'P';
	float f1 = 56.43F; or 56.43f;
	double d1 = 547567.345634643654;
	string str = "welcome to data types";


 *
 */