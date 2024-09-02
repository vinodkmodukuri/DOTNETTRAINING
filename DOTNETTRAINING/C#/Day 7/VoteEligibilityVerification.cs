using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class VoteEligibilityVerification
    {
        public static void Main(string[] args)
        {
            //a citizen vote verification
            int age;
            Console.WriteLine("Enter the age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");

            }

            else
            {
                Console.WriteLine("You must turn 18 to vote");

            }
        }
    }
}

