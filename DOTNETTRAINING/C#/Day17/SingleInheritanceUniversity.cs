using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class University
    {
        protected int universityID;
        protected string universityName, universityLocation;
    }

    class Student1 : University
    {
        protected int studentID;
        protected string studentName1;

        public void AcceptStudentInfo()
        {
            Console.WriteLine("Enter the University ID");
            universityID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the University Name");
            universityName = (Console.ReadLine());
            Console.WriteLine("Enter the Student ID");
            studentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name");
            studentName1 = (Console.ReadLine());
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("University ID is : {0}", universityID);
            Console.WriteLine("UNiversity Name is : {0}", universityName);
            Console.WriteLine("Student ID is: {0}", studentID);
            Console.WriteLine("Stduent name is: {0}", studentName1);
        }
    }
    internal class SingleInheritanceUniversity
    {

        public static void Main(string[] args)
        {
            Student1 mystudent = new Student1();
            mystudent.AcceptStudentInfo();
            mystudent.DisplayStudentInfo();
            Console.ReadLine();
        }
    }
}
