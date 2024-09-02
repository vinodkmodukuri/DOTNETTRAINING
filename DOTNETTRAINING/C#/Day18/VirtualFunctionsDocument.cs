using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Program1
{

    public class Document1
    {
        public virtual void Save()
        {
            Console.WriteLine("How the document will be saved");

        }
    }

    class PowerPoint1 : Document1
    {
        public override void Save()
        {
            Console.WriteLine("The Power Point saves in .pptx format");
        }

    }

    class WordDocument1 : Document1
    {
        public override void Save()
        {
            Console.WriteLine("The Word Document saves in .docx format");
        }

    }

    class Implement
    {
        public void FunctionCall(Document1 TypeOfDocument)
        {
            TypeOfDocument.Save();
        }
    }
    internal class VirtualFunctionsDocument
    {
        public static void Main(string[] args)
        {
            Document1 document1 = new Document1();
            PowerPoint1 powerPoint1 = new PowerPoint1();
            WordDocument1 wordDocument1 = new WordDocument1();
            document1.Save();
            powerPoint1.Save();
            wordDocument1.Save();


            Implement mydocument1 = new Implement();
            mydocument1.FunctionCall(powerPoint1);
            mydocument1.FunctionCall(wordDocument1);
            Console.ReadLine();

        }
    }
}
