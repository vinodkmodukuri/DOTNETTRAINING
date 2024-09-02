using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{


    internal class FileStreamReadWrite
    {
        public void WriteData()
        {
            //FileStream fileObj = new FileStream(file Name/Path, FileMode.field, FileAccess.field, FileShare.field);
            FileStream fileStream = new FileStream("Student.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write("Student Name is Shiva and his roll number is 3");
            streamWriter.Close();
            fileStream.Close();
        }

        public void ReadData()
        {
            FileStream fileStream1 = new FileStream("Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream1);
            string str = streamReader.ReadToEnd();
            Console.WriteLine("The student details are: {0}", str);
            streamReader.Close();
            fileStream1.Close();
           
        }

        public static void Main (String[] args)
        {
            FileStreamReadWrite myobj = new FileStreamReadWrite();
            myobj.WriteData();
            myobj.ReadData();

            Console.ReadLine();
        }
    }
}
