using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
   abstract class Document
    {
        public abstract void Open();
        public abstract void Save();
        public abstract void Close();
        public abstract void Print();

    }

    class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Open the word document");

        }
        public override void Save()
        {
            Console.WriteLine("Save the word document");

        }
        public override void Close()
        {
            Console.WriteLine("Close the word document");

        }
        public override void Print()
        {
            Console.WriteLine("Print the word document");

        }
    }


    class PowerPoint : Document
    {
        public override void Open()
        {
            Console.WriteLine("Open the Power Point");

        }
        public override void Save()
        {
            Console.WriteLine("Save the Power Point");

        }
        public override void Close()
        {
            Console.WriteLine("Close the Power Point");

        }
        public override void Print()
        {
            Console.WriteLine("Print the Power Point");

        }
    }

    internal class AbstractClassDocument
    {
        public static void Main(string[] args)
        {
            WordDocument doc = new WordDocument();
            doc.Open();
            doc.Close();
            doc.Save();
            doc.Print();

            PowerPoint powerPoint = new PowerPoint();
            powerPoint.Open();
            powerPoint.Save();
            powerPoint.Close();
            powerPoint.Print();
        Console.ReadLine();
        }
    }
}
