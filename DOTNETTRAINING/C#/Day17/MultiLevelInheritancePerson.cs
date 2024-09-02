using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Person
    {
        protected string name, email;
        protected int age, phonenumber;
    }

    class Employee : Person
    {
        protected int empID;
        protected string department, designation;
    }

    class Job : Employee
    {
        protected string jobType;

        public void AcceptEmployeeDetails()
        {
            Console.WriteLine("Enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the employee email");
            email = Console.ReadLine();
            Console.WriteLine("Enter the employee ID");
            empID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employee department");
            department = Console.ReadLine();
            Console.WriteLine("Enter the employee designation");
            designation = Console.ReadLine();
            Console.WriteLine("Enter the employee jobtype");
            jobType = Console.ReadLine();
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("The employee name is : {0}", empID);
            Console.WriteLine("The employee email is: {0}", email);
            Console.WriteLine("The employee empID is: {0}", empID);
            Console.WriteLine("The employee email is: {0}", email);
            Console.WriteLine("The employee job type is: {0}", jobType);
        }
    }

    internal class MultiLevelInheritancePerson
    {
        public static void Main(string[] args)
        {
            Job myemp = new Job();
            myemp.AcceptEmployeeDetails();
            myemp.DisplayEmployeeDetails();
            Console.ReadLine();
        }
    }
}
