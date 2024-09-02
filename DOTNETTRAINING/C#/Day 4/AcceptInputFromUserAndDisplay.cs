using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class AcceptInputFromUserAndDisplay
    {
        public static void Main(string[] args)
        {

            //Declaration
            int studentID; 
            Console.WriteLine("Enter the student ID");

            //Accept value from the user.
            studentID = Convert.ToInt32(Console.ReadLine());

            //Display the value 
            Console.WriteLine("The student ID is {0}", studentID);

            //For float 

            float gpa;
            Console.WriteLine("Enter your GPA");
            gpa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Your GPA is: {0}", gpa); ;

            //double 

            double pivalue;
            Console.WriteLine("Enter pi value");
            pivalue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pi value is: {0}", pivalue);


            //string
            string studentName;
            Console.WriteLine("Enter the student name");
            studentName = Console.ReadLine();
            Console.WriteLine("Your name is : {0}", studentName);

            Console.ReadKey();
        }
    }
}
