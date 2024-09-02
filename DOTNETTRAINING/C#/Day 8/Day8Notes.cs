/*using System;

July 25
Loops

Looping Constructs
-------------------------------
Loop
-------
A loop is a sequence of instructions repeated more than once.

while loop
do..while loop
for loop


initialization
condition
increment/decrement


while loop
---------------
It is a pre test condition.
It will check for the condition , if the condition is true then only 
it will execute the statements, else it will not execute.

syntax:
-------------
initialization;
while (condition)
{
    //statements;
    increment / decrement;
}

Write a program to display 1 to 5 numbers.

int i=1; //initialization
while (i <= 5)  //condition  1<=5y 2<=5y 3<=5y 4<=5y 5<=5y 6<=5n
{
    Console.WriteLine(i);  // 1 2 3 4 5
    i++; //increment 2 3 4 5 6
}

---------------
do ..while loop
--------------------
If we want to execute the statements atleast once without checking
the condition, then we can use do..while loop.

syntax:
-----------
initialization;
do
{
    //statements;
    increment / decrement;
} while (condition);

Write a program to display 1 to 5 numbers.

int i=1; //initialization
do
{
    Console.WriteLine(i); // 1 2 3 4 5
    i++; //increment  2 3  4 5 6
} while (i <= 5);  //condition 2<=5y 3<=5y 4<=5y 5<=5y 6<=5n

-------
for loop
---------- -
syntax:
-----------
for (initialization; condition; increment / decrement)
    {
        //statements;
    }

Write a program to display 1 to 5 numbers

for(int i=1; i <= 5; i++)
{
    Console.WriteLine(i);  //1 2  3  4  5 
}

--------------------

While loop
----------------
1.Write a program to display 1 to 10 numbers.
2. Write a program to display the sum of first 10 numbers.
3. Write a program to display the first 10 odd numbers.
4. Write a program to display the sum of first 10 odd numbers.
5. Write a program to display the first 10 even numbers.
6. Write a program to display the sum of first 10 even numbers.

do..while loop
----------------------
7. Write a program to accept an multiplication table number
and display that particular multiplication table.
eg: 5 * 1 = 5
      5 * 2 = 10......5 * 10 = 50

8.Write a program to accept a number and display the sum of the digits.
eg: 125 = 1 + 2 + 5 = 8
9.Write a program to accept a number and display the sum of the digits square.
eg: 125 = 1 * 1 + 2 * 2 + 5 * 5 = 1 + 4 + 25 = 30
10.Write a program to accept a number and display the sum of the digits cube.
eg: 125 = 1 * 1 * 1 + 2 * 2 * 2 + 5 * 5 * 5 = 1 + 8 + 125 = 134
11.Write a program to accept a number and check whether the number is an Armstrong number or not.
Armstrong number means the sum of the digits cube should be equal to the given number.
eg: 153 = 1 * 1 * 1 + 5 * 5 * 5 + 3 * 3 * 3 = 1 + 125 + 27 = 153.

for loop
------------
12.Write a program to display 10 to 20 numbers.
13.Write a program to display only the even numbers from 1 to 100.
14.Write a program to accept a number and display the factorial of the given number.
factorial eg: 5 factorial = 5 * 4 * 3 * 2 * 1 = 120
15.Write a program to accept a number and display the fibonocci series.
eg: 0 1 1 2 3 5 8 13 21...
fibonocci series means adding the previous two numbers is the third number.
eg: 0 + 1 = 1
      1 + 1 = 2
      1 + 2 = 3

------------------------------ -
*//**/