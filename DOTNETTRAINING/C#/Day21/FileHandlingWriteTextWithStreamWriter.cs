using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1.Day21
{
    internal class FileHandlingWriteTextWithStreamWriter
    {

        public static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("Line.txt",FileMode.Create, FileAccess.Write);
            StreamWriter swriter = new StreamWriter(fileStream);
            string[] lines = { "First Line", "Second Line", "ThirdLine" };

            foreach (string line in lines)
            {
                swriter.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
