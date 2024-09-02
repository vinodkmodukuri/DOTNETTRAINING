using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EFCodeFirstApproachEmployee
{
    internal class Program
    {
        public void Insert()
        {
            int empId;
            string empName, empTitle, empAddress, empCity, empRegion, empPostalCode, empCountry, empPhone;

            Console.WriteLine("Enter the employee ID");
            empId= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            empName = Console.ReadLine();
            Console.WriteLine("Enter the Employee Title");
            empTitle = Console.ReadLine();
            Console.WriteLine("Enter the Employee Address");
            empAddress = Console.ReadLine();
            Console.WriteLine("Enter the Employee City");
            empCity = Console.ReadLine();
            Console.WriteLine("Enter the Employee Region");
            empRegion = Console.ReadLine();
            Console.WriteLine("Enter the Employee PostalCode");
            empPostalCode = Console.ReadLine();
            Console.WriteLine("Enter the Employee Country");
            empCountry = Console.ReadLine();
            Console.WriteLine("Enter the Employee Phone");
            empPhone = Console.ReadLine();

            //Create an object for context class
            EmployeeContext employeeContext = new EmployeeContext();
            //Create an object for model class 
            Employee employee = new Employee();

           employee.EmployeeID = empId;
           employee.EmployeeName = empName;
           employee.Title = empTitle;
           employee.Address = empAddress;
           employee.City = empCity;
           employee.Region = empRegion;
           employee.PostalCode = empPostalCode;
           employee.Country = empCountry;
           employee.Phone = empPhone;

            //Use the EmployeeContext object and Table name from Employee Context Class, use the add method and pass the Employee model class object as a parameter
            employeeContext.Employees.Add(employee);
            employeeContext.SaveChanges();
            Console.WriteLine("Data inserted Successfully");

        }

        public void Update()
        {
            int id;
            Console.WriteLine("Enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());

            EmployeeContext employeeContext = new EmployeeContext();
            var result = employeeContext.Employees.Find(id);
            if (result != null)
            {
                string name;
                Console.WriteLine("Enter the employee name");
                name = Console.ReadLine();
                result.EmployeeName = name;
                employeeContext.SaveChanges();
                Console.WriteLine("The record updated successfully");

            }
            else
            {
                Console.WriteLine("customer ID does not exist");
            }
        }

        static void Main(string[] args)
        {
            Program myobj = new Program();
            //myobj.Insert();
            myobj.Update();
            Console.ReadKey();
        }
    }
}
