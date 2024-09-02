using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class DataTypes
    {
        public static void Main(string[] args)
        {

            //Data Type = Integer
            int studentRollNumber = 23; //Variable Declaration and Initialization the value 
            Console.WriteLine(studentRollNumber); //Just displaying the variable 
            Console.WriteLine("Student roll number is: {0}", studentRollNumber); //Displaying  the variable with message 
            
            //Data Type = Character 

            char grade = 'A';
            Console.WriteLine(grade);
            Console.WriteLine("Student grade is {0}", grade);

            //Displaying the both Interger + Character data types in one line 
            Console.WriteLine("Student roll number is {0}, and grade is {1}", studentRollNumber, grade);

            
            //Data Type = float 
            float attendance = 78.99f;
            Console.WriteLine(attendance);
            Console.WriteLine("Student attendance is:  " + attendance);

            //Displaying Interger + Character + Float 
            Console.WriteLine("Student roll number is {0}, Grade is {1}, Attendance is {2}", studentRollNumber, grade, attendance);

           
            //Data Type = Double 
            double percentage = 78.5789d;
            Console.WriteLine(percentage);
            Console.WriteLine("Printing the double value " + percentage);

            //Displaying Interger + Character + Float + double

            Console.WriteLine("Student roll number is {0}, Grade is {1}, Attendance is {2}, Percentage is {3}", studentRollNumber, grade, attendance, percentage);

            string university = "JNTU";
            Console.WriteLine(university);
            Console.WriteLine("University is " + university);

            //Displaying Interger + Character + Float + double + string

            Console.WriteLine("Student roll number is {0}, Grade is {1}, Attendance is {2}, Percentage is {3} and the University is {4}", studentRollNumber, grade, attendance, percentage, university);
            Console.ReadKey();

        }
    }
}
