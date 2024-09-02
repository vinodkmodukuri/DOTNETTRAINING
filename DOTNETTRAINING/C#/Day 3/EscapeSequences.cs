using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class EscapeSequences
    {
        //Learning Escape Sequences in C#
        static void Main(string[] args)
        {
            Console.WriteLine("This is first \n my C# program"); // \n Move the cursor to the start of tne next line
            Console.WriteLine("It inserts some white spaces \t to the left of the cursor ");// \t Horizontal tab 
            Console.WriteLine("Diaply the \'single quote\'"); // \' Single quote 
            Console.WriteLine("\"Quotation Marks\""); // \" double quotation marks
            Console.WriteLine("Insert \\ backslash"); // \\Insert backslash
            Console.WriteLine("Generate a bell or alram sound \a"); // \a Generate bell/alaram sound 
            Console.WriteLine("It moves the cursor to the \r start of the current line"); // \r It moves the cursor to the start of the current line
            Console.WriteLine("Move the cursor \b\b\b\b backward let's see"); // \b Move the cursor backward 
            Console.WriteLine(@"                @Verbatim string literal

                                                adding a new line" ); //@Verbatim string literal @ - Keep all whitespaces and characters  without the need to escape to backslash   
            Console.WriteLine("Generating invoices for customer \"Quick Mart Corp\"");
            Console.WriteLine("Invoice 1021 \t\tComplete!");
            Console.WriteLine("Invoice 1022 \t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.WriteLine(@"c:\invoices");
            Console.ReadLine();       
        }
    }
}
