using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class StudentResults
    {

        public static void Main(string[] args)
        {
            int subject1;
            int subject2;
            int subject3;
            string result1 = "PASS";
            string result2 = "FAIL";

            Console.WriteLine("Enter the subject 1 markes between 0 to 100");
            subject1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the subject 2 markes between 0 to 100");
            subject2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the subject 3 markes between 0 to 100");
            subject3 = Convert.ToInt32(Console.ReadLine());

            if (subject1 < 0 || subject2 < 0 || subject3 < 0)
            {

                Console.WriteLine("Invalid marks");
            }

            if (subject1 > 100 || subject2 > 100 || subject3 > 100)
            {

                Console.WriteLine("Invalid marks");
            }

            if (subject1 <= 35 || subject2 <= 35 || subject3 <= 35)

            {
                Console.WriteLine("Subject is {0}", result2);
            }
            else
            {
                Console.WriteLine("Subject is {0}", result1);

            }

            int total = subject1 + subject2 + subject3;

            Console.WriteLine("The total marks are {0}", total);

            //If any of the subject result is FAIL, the student is failed 
            if (subject1 <= 34 || subject2 <= 34 || subject3 <= 34)
            {
                Console.WriteLine("The student is FAILED the exams ");
            }

            else
            {
                Console.WriteLine("The student is passed the exams");
            }


            float percentage = total;
            Console.WriteLine("The percentage is {0} % ", (percentage / 300) * 100);

        }
    }
}
