using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program1
{


    internal class FileHandlingAskUserIinput
    {
        public void AskUserInput()
        {
            //FileStream fileObj = new FileStream(file Name/Path, FileMode.field, FileAccess.field, FileShare.field);

            //Provides a stream for a file 
            FileStream fileStream = new FileStream("Employee.txt", FileMode.Create, FileAccess.Write);
            

            //Implement a text writer for writing characters to a stream 
            StreamWriter streamWriter = new StreamWriter(fileStream);  //What we want to write 

            //Ask the user 
            Console.WriteLine("Enter employee Name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter employee ID");
            string empID = Console.ReadLine();

            //Write a string to the stream
            streamWriter.Write(empName);
            streamWriter.Write(empID);

            streamWriter.Close();
            fileStream.Close();
        }

        public void ReadUserInputData()
        {
            FileStream fileStream1 = new FileStream("Employee.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream1);
            string str = streamReader.ReadToEnd();
            Console.WriteLine("The employee details are: {0}", str);
            streamReader.Close();
            fileStream1.Close();

        }

        public static void Main(String[] args)
        {
            FileHandlingAskUserIinput myobj = new FileHandlingAskUserIinput();
            myobj.AskUserInput();
            myobj.ReadUserInputData();

            Console.ReadLine();
        }
    }
}
