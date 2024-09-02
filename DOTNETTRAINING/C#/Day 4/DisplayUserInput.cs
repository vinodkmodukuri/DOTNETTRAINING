using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class DisplayUserInput
    {
        public static void Main(string[] args)
        {
            //Declatation 
            int num1;

            //Input from the user 
            Console.WriteLine("Enter the roll number");
            num1=Convert.ToInt32(Console.ReadLine());

            //Display the roll number

            Console.WriteLine("Your roll number is {0}", num1 );
            char grade;
            Console.WriteLine("Enter your grade"); 
            grade=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your grade is: {0}", grade);

            //For float 

            float gpa;
            Console.WriteLine("Enter your GPA"); 
            gpa=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Your GPA is: {0}", gpa); ;

            //double 

            double pivalue;
            Console.WriteLine("Enter pi value"); 
            pivalue=Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("pi value is: {0}", pivalue);


            //string
            string name;
            Console.WriteLine("Enter your name"); 
            name =Console.ReadLine();
            Console.WriteLine("Your name is : {0}", name);
          
            Console.ReadKey();

        }
    }
}
