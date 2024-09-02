using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
   public delegate bool IsPromotable(Emp emp);


    public class Emp
    {
        public int ID, salary, experience;
        public string empName;

        public void EmpAccept()
        {
            Console.WriteLine("Enter the Employee ID");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Emp Salary");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the employee experience");
            experience= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Emp Name");
            empName = Console.ReadLine();

        }

        public void EmpDisplay()
        {
            Console.WriteLine("Emp ID is {0}", ID);
            Console.WriteLine("Emp Salary is {0}", salary);
            Console.WriteLine("Emp experice is {0}", experience);
            Console.WriteLine("Emp name is {0}", empName);
        }

        public void PromoteEmployee(IsPromotable isEligibleToPromote)
        {
            if(isEligibleToPromote(this))
            {
                Console.WriteLine("Emplyoyee {0} is promoted", empName);
            }
            else
            {
                Console.WriteLine("Emplyoyee {0} is not promoted", empName);

            }
        }

    }
    internal class DelegateEmpDemo
    {
        public static void Main(string[] args)
        {
            Emp myEmployee = new Emp();

            IsPromotable isPromotable = new IsPromotable(Promote);

            myEmployee.EmpAccept();
            myEmployee.EmpDisplay();

            myEmployee.PromoteEmployee(isPromotable);

            Console.ReadKey();
        }

        public static bool Promote(Emp emp)
        {
           if (emp.experience >= 5)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

    }
}
