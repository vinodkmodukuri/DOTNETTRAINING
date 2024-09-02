using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirstApproachUniversityDepartment
{
    internal class Program
    {
        public void Insert()
        {
            int depID;
            string depName, depDescription, depHead;
            Console.WriteLine("Enter the department ID");
            depID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the department name");
            depName = Console.ReadLine();
            Console.WriteLine("Enter the department description");
            depDescription = Console.ReadLine();
            Console.WriteLine("Enter the department head");
            depHead = Console.ReadLine();


            UniversityEntities1 universityEntities1 = new UniversityEntities1();
            Department department = new Department();

            department.department_id = depID;
            department.department_name = depName;
            department.department_description = depDescription;
            department.department_head = depHead;


            universityEntities1.Departments.Add(department);
            universityEntities1.SaveChanges();
            Console.WriteLine("Department added successfully");

        }

        public void Update()
        {
            int depid;
            Console.WriteLine("Enter the department ID to update the department head");
            depid = Convert.ToInt32(Console.ReadLine());

            UniversityEntities1 universityEntities1 = new UniversityEntities1();
            var result = universityEntities1.Departments.Find(depid);
            if (result != null)
            {
                string depHeadName;
                Console.WriteLine("Enter the new department head");
                depHeadName = Console.ReadLine();
                result.department_head = depHeadName;
                universityEntities1.SaveChanges();
                Console.WriteLine("Department head is updated successfully");
            }
            else
            {
                Console.WriteLine("Department ID does not exist");
            }
        }
        public void Display()
        {
            UniversityEntities1 universityEntities1 = new UniversityEntities1();
            var result = universityEntities1.Departments;
            foreach (var item in result)
            {
                Console.WriteLine("Department ID is {0}", item.department_id);
                Console.WriteLine("Department Name is {0}", item.department_name);
                Console.WriteLine("Department Head is {0}", item.department_head);
                Console.WriteLine("Department Description is {0}", item.department_description);
            }

        }

        public void Delete()
        {
            int DepID;
            Console.WriteLine("Enter the Department ID to delete the record");
            DepID = Convert.ToInt32(Console.ReadLine());

            UniversityEntities1 universityEntities1 = new UniversityEntities1();

            var result = universityEntities1.Departments.Find(DepID);

            if (result != null)
            {
                Console.WriteLine("Deleting the department record {0}", result.department_id);
                universityEntities1.Departments.Remove(result);
                universityEntities1.SaveChanges();
                Console.WriteLine("Successfully deleted the department id {0}", DepID);
            }
            else
            {
                Console.WriteLine("Invalid Department ID");
            }
        }





        static void Main(string[] args)
        {
            Program myprogram = new Program();
            //myprogram.Insert();
            //myprogram.Update();
            //myprogram.Display();
              myprogram.Delete();

            Console.ReadLine();

        }
    }
}
