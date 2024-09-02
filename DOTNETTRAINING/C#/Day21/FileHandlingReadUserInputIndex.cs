using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program1
{


    internal class FileHandlingReadUserInputIndex
    {
        public void AskUserInput()
        {
            //FileStream fileObj = new FileStream(file Name/Path, FileMode.field, FileAccess.field, FileShare.field);

            //Provides a stream for a file - Create a file, write access to the file 
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

            int position;
            Console.WriteLine("Etner the index position");
            position = Convert.ToInt32(Console.ReadLine());

            streamReader.BaseStream.Seek(position, SeekOrigin.Begin);
            string str = streamReader.ReadLine();
     
            while (str != null)
            {
                Console.WriteLine("Employee details are {0}", str);
                str = streamReader.ReadLine();
            }

            streamReader.Close();
            fileStream1.Close();

        }

        public static void Main(String[] args)
        {
            FileHandlingReadUserInputIndex myobj = new FileHandlingReadUserInputIndex();
            myobj.AskUserInput();
            myobj.ReadUserInputData();

            Console.ReadLine();
        }
    }
}
