using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class StudentTotalMarks
    {
        // Write a program and display 3 subject marks including the result of exam along with total and percentage

        public static void Main(string[] args)
        {

            string studentName;
            Console.WriteLine("Enter your name");
            studentName = Console.ReadLine();
            Console.WriteLine("Your name is: {0}", studentName);

            int marks;
            Console.WriteLine("Enter your marks");
            marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your marks are: {0}", marks);

            Console.WriteLine("Student name is {0}, and the marks are: {1}", studentName,marks);

            float gpa;
            Console.WriteLine(" Enter your GPA");
            gpa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Student GPA is {0}", gpa);

            Console.WriteLine("Student name is {0}, \n Student marks: {1}, \n Student GPA {2}", studentName, marks, gpa);

            double projectScore;
            Console.WriteLine("Enter your project score");
            projectScore = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Project score is {0}", projectScore);

            Console.WriteLine("Student name is {0}, \t \n Student marks: {1}, \n Student GPA {2} \n Student project score {3}", studentName, marks, gpa, projectScore);

            Console.ReadLine();

        }
    }
}
