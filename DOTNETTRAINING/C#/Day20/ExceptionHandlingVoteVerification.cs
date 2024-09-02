using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program1
{
    class Vote
    {
        public void Age(int age)
        {
            if (age <18 )
            {
                throw new AgeValidationException("Age must be more than or equal 18");
            }
        }
        
    }
    public class AgeValidationException : ApplicationException

    {
        public AgeValidationException( string message) : base (message)
        {
           
        }
    }

    internal class ExceptionHandlingVoteVerification
    {
        public static void Main(String[] args)
        {
            try{
                int age;
                Console.WriteLine("Enter the age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The entered age is {0}", age);

                Vote myvote = new Vote();
                myvote.Age(age);
                Console.WriteLine("Valid age to vote");           
            }

            catch(AgeValidationException myobj)
            {
                Console.WriteLine("Invalid age {0}", myobj.Message);
            }

            catch(FormatException myobj2)
            {
                Console.WriteLine("Enter the valid age in numbers {0}", myobj2.Message);
            }
            Console.ReadKey();
        }
    }
}
