using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Program
    {
        public void Insert()
        {
            int sID;
            string SFristName, SLastName, sEmail, SPhone;
            Console.WriteLine("Enter the student ID");
            sID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student first name");
            SFristName = Console.ReadLine();
            Console.WriteLine("Enter the student last name");
            SLastName = Console.ReadLine();
            Console.WriteLine("Enter the student email");
            sEmail = Console.ReadLine();
            Console.WriteLine("Enter the student phone number");
            SPhone = Console.ReadLine();

            StudentContext studentContext = new StudentContext();
            Student student = new Student();

            student.StudentID = sID;
            student.StudentFirstName = SFristName;
            student.StudentLastName = SLastName;
            student.StudentEmail = sEmail;
            student.StudentPhone = SPhone;

            studentContext.Students.Add(student);
            studentContext.SaveChanges();
            Console.WriteLine("Student record is added successfully");
        }

        public void Update()
        {
            int id;

            Console.WriteLine("Enter the student ID to update phone number");
            id = Convert.ToInt32(Console.ReadLine());

            StudentContext studentContext = new StudentContext();

            var result = studentContext.Students.Find(id);
            if (result != null)
            {
                string PhoneNumber;
                Console.WriteLine("Enter the phone number");
                PhoneNumber =Console.ReadLine();
                result.StudentPhone = PhoneNumber;
                studentContext.SaveChanges();
                Console.WriteLine("The student phone number updated successfully");
            }
            else
            {
                Console.WriteLine("Invalid student ID");
            }
        }

        public void Display()
        {
            StudentContext studentContext = new StudentContext();

            var result = studentContext.Students;

            foreach (var item in result)
            {
                Console.WriteLine("Student ID is {0}",item.StudentID);
                Console.WriteLine("Student First Name is {0}", item.StudentFirstName);
                Console.WriteLine("Student Last Name is {0}", item.StudentLastName);
                Console.WriteLine("Student Phone Number is {0}", item.StudentPhone);
                Console.WriteLine("Student Email is {0}", item.StudentEmail);
            }
        }

        public void Delete()
        {
            int ID;
            Console.WriteLine("Enter the student ID to delete the record");
            ID = Convert.ToInt32(Console.ReadLine());

            StudentContext studentContext = new StudentContext();

            var result = studentContext.Students.Find(ID);

            if (result != null)
            {
                Console.WriteLine("Deleting the student record {0}", result.StudentID);
                studentContext.Students.Remove(result);
                studentContext.SaveChanges();
                Console.WriteLine("Successfully deleted the student id {0}", ID);
            }
            else
            {
                Console.WriteLine("Invalid student ID");
            }
        }


        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Insert();
            //myprogram.Update();
            //.myprogram.Display();
           // myprogram.Delete();
            Console.ReadLine();
        }
    }
}


