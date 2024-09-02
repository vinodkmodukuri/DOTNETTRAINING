/* C# Console Applications 
 * ----------------------
 * 
 * C# (CSharp) is an Object Oriented-Programming language which is developed by Microsoft
 * 
 * Any Object Oriented Programming languages (C++, C#, Java) consists  - We will learn about this in the coming classes 
 * Class
 * Object
 * Encapusulation 
 * Abstraction 
 * Inheritance 
 * Polymorphism 
 * 
 * What is Object-Oriented Programming?
 * -----------------------------------
 * It is one of most popular methodologies which is used in the S/W industry for development 
 * It is one powerful model which is used to create software programs 
 * 
 * What is bject-Orientation?
 * ---------------------------
 * It is a software development methodology based on Real World System 
 * An object is the core concept involved in object orientation 
 * An object is the representation of real world 
 * Examples: a car, a bird, a window, a pen ........
 * Object oriented programming consistes of classes, methods, objects 
 * 
 * What are he characteristics of an object?
 * ---------------------------------------------
 * 1. State - Drive, Parking 
 * 2. Behaviour - Speed varie (slow, speed)s, Dirction varies, 
 * 3. Identity - Two objects can have the same state and behaviour but it should differ in identity 
 * 
 * What is a Class?
 * -----------------
 * 
 * A calss is a way to bind it's associated functions and members together 
 * 
 * Characteristics of Object-Oriented Programming
 * ----------------------------------------------
 * 1. Reusability - 2 seater to 4 seater 
 * 2. Resilance to change - Adding new features 
 * 3. Existence as difference forms - Car colision with high speed and low speed (Polymorphism)
 * 
 * Phases of Object Oriented Object Methodology
 * -------------------------------------------
 * SDLC 
 *  1. Analysis 
 *  2. Design 
 *  3. Implementation 
 *  4. Testing 
 *  
 *  
 *  CSharp
 *  -------------
 *  Generation of Computers 
 *  Generations of Programming Languages 
 *  
 *  Machine Language 
 *  Assembly Language 
 *  Basic Combined Programming Language 
 *  B
 *  C - Dennis Ritchie
 *  C++ (C with classes ) 
 *  Classes language - Simula67
 *  
 *  C# is an Object Oriented Programming Language Developed by Microsoft 
 *  
 *  
 *  What is .NET Framework
 *  ----------------------
 *  .NET Framework is a technology suports building and running the applications 
 *  It is the foundation on which we design, develop, and deploy the application 
 *  .NET Framework consists of 
 *      1. Common Language Runtime (CLR)
 *      2. Common Language Specification (CLS)
 *      3. Just-In-Time Complier (JIT)
 *      
 *  Microsoft introduced visual studio .Net which is a tool for developing .Net applications by using programming languages like C#, VB, Visual C++, F#, VJ#,...
 *  All .Net products use XML for describing and exchanging data between applications.
 *  
 *  
 *  Web Service
--------------------
A web service is an application or business logic which is accessible through standard protocols like http, soap. we can access the service by using url.
A web service is a collection of web methods.

[WebMethod]
public int Add(int num1, int num2)
{
return num1+num2;
}

Components of .Net Framework
------------------------------------------------
	
	Console Application, Windows Forms, Web Applications
				|
		.Net Framework Base class libraries
				|
		Common Language Runtime 


CLR
-------
It is one of the most essential component in .net framework.
CLR is the environment where all the programs using .net technologies are executed.

C# program -machine code( executable code).

It will be done in two steps.
step 1:
C# program -> Intermediate language code (IL ) or (MSIL) 
This IL code will be understood only by CLR.

step 2:
IL -> using JIT compiler -> machine code

CLR provides services like 
	code compilation, 
	memory allocation and 
	garbage collection.

A Set of rules is known as CLS.
One of the specification in CLS is Common Type System (CTS).
It provides a type system which is common across all languages.

Compilation
-------------------
It is a process of creating an executable program from source code.
Metadata - data about its own (version, dependencies, classes, interfaces,...)
IL + metadata = Assembly.
An Assembly is the smallest deployable unit.


A Namespace is a collection of classes.
Any code which is written in C# or Vb.net is known as managed code.

 */