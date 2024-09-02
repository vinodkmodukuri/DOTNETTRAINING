using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Structures
    {
        struct StudentDetails
        {
            public int stdid;
            public string sname;
            public string course;
        }
        public static void Main(string[] args)
        {
            StudentDetails student =new StudentDetails();
            student.stdid = 1;
            student.sname = "Raj";
            student.course = ".NET";
            Console.WriteLine("The student id is {0},  syudent name is {1}, and the course is {2}", student.stdid, student.sname, student.course);
            Console.ReadKey();
        }
    }
}
