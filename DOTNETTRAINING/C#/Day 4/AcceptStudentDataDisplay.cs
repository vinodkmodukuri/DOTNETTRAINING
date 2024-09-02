using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program1.AcceptStudentDataDisplay;

namespace Program1
{
    internal class AcceptStudentDataDisplay
    {
        //Initialize
         public int studentID;
         public float gpa;
         public double pivalue;
         public string studentName; 
       

        //Accept Values from the user 

        public void Accept()
        {
            Console.WriteLine("Enter the student ID");
            studentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student gpa");
            gpa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the pi-value");
            pivalue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the name of the student"); 
            studentName= Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("The student ID is {0}", studentID); 
            Console.WriteLine("GPA is {0}", gpa);
            Console.WriteLine("The pi-value is {0}", pivalue);
            Console.WriteLine("The student name is {0}", studentName); 
        }
        public static void Main(string[] args)
        {
            AcceptStudentDataDisplay myStudent = new AcceptStudentDataDisplay(); //Instance or Object
            myStudent.Accept();
            myStudent.Display();
            Console.ReadLine();
        }
    }
}
