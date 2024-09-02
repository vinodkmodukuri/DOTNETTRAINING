/*
Arrays

Arrays
----------
An Array is a collection of elements of same data type referenced by a common name.

Array elements are accessed by using a single name and an index 
number represents the position of the element within the array.

Array index or subscript starts from Zero.

Array is a reference type data type.


Single Dimensional Array
Two Dimensional Array


Single Dimensional Array
--------------------------------------
Values will be stored in contiguous memory locations.

syntax:
------------
Initialization
-------------------
<datatype>[ ]<arrayname>=new <datatype>[size]{values};
eg:
int [ ] arr1=new int[5]{23,12,67,54,89};

Declaration
---------------
Syntax:
---------
<datatype>[ ] <arrayname>=new <datatype>[size];
eg:
int [ ] arr2=new int[5];

<datatype>- It is used to specify the data type for the elements.
[ ] - It is used to specify the Rank of the Array.
	Rank is used to specify the size of the Array (single or multi dimensional)

<arrayname> - It is used to specify the name of the array using which the elements of the array will be initialized and modified.

internal class SingleDimArray
    {
        public static void Main()
        {
            int[] arr1 = new int[5] {34,56,12,87,90 };

            Console.WriteLine("values are");
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr1[1]);
            Console.WriteLine(arr1[2]);
            Console.WriteLine(arr1[3]);
            Console.WriteLine(arr1[4]);

            Console.WriteLine("values:");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadLine();
        }
    }
------------------
internal class SingleDimArrayAccDisp
    {
        public static void Main()
        {
            //Declaration
            int[] arr2 = new int[5];
            int i;  
            //Accept
            Console.WriteLine("Enter values");
           for(i=0;i<5;i++)
            {
        arr2[i]= Convert.ToInt32(Console.ReadLine());
            }

            //Display
            Console.WriteLine("values are:");
            for(i=0;i<5;i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.ReadKey();
        }
    }

------------------------

Two  Dimensional Arrays
----------------------------------------
Information or data will be stored in row and column format.

syntax:
------------
Initialization
-------------------
<datatype> [ , ] <arrayname>=new <datatype>[rowsize,columnsize]{values};
eg:
int [ , ] arr1=new int[2,2]{  {12,34} , {56,78} };


Declaration
------------------
<datatype> [ , ] <arrayname>=new <datatype>[rowsize,columnsize];

eg:

int [ , ] arr2=new int[2,2];


 internal class Arraytwodim
    {
        public static void Main()
        {
            //initialization
            int[,] arr1 = new int[2, 2] { { 23,45}, {12,98 } };
            int i, j;

            //display
            for (i = 0; i < 2; i++) //rows
            {
                for (j = 0; j < 2; j++) //columns
                {
                    Console.Write("      {0}", arr1[i,j]);

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

-------------------
internal class ArrayTwoDimAccDisp
    {
        public static void Main()
        {
            //declaration
            int[,] arr2 = new int[2, 2];

            int i, j;

            //Accept
            Console.WriteLine("Accept values:");
            for(i=0;i<2;i++)
            {
                for(j=0;j<2;j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Display
            Console.WriteLine("values are :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("    {0}", arr2[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
----------------------

Single Dimensional Array

1. Write a program to initialize an array of size 5 and display values.
2. Write a program to accept an array of size 5 , accept and display.
3. Write a program to accept array size, accept and display values.

Two Dimensional Array
4. Write a program to initialize and display a 2*2 matrix.
5. Write a program to accept and display 3*3 matrix
6. Write a program to accept array size, accept and display values.
7. Write a program to accept row size, column size of a matrix, accept and display values.
8. Write a program to accept row size and column size of two matrices, accept and display values.
9. Write a program to accept row size and column size of two matrices, accept and display values and perform Matrix Addition.
10. Write a program to accept row size and column size of two matrices, accept and display values and perform Matrix Multiplication.

-------


 



 */