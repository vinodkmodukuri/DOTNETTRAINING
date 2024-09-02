using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{

    abstract class GovernmentOfficial
    {
        protected int employeeId, age;
        protected string employeename, location;

        public abstract void  PerformDuties();
        public abstract void ReportToPublic();
    }
    class President : GovernmentOfficial
    {

        public override void PerformDuties()
        {
            Console.WriteLine("The president performs duties at WhiteHouse");
            Console.WriteLine("President also implement and enforces the laws written by Congress");
            Console.WriteLine("Also appoints the heads of the federal agencies");
        }
        public override void ReportToPublic()
        {
            Console.WriteLine("The President must report to the public when necessary");

        }
    }
    class Senator : GovernmentOfficial
    {
        public override void PerformDuties()
        {
            Console.WriteLine("The Senator performs the duties at the state level");

        }
        public override void ReportToPublic()
        {
            Console.WriteLine("The Senator must report to the public with in the state");
        }

    }
    internal class AbstractClassGovernmentOfficial
    {
        public static void Main(string[] args)
        {
            President president = new President();
            president.PerformDuties();
            president.ReportToPublic();
                
            Senator senator = new Senator();
            senator.PerformDuties();
            senator.ReportToPublic();
            Console.ReadLine();
        }
    }
}
