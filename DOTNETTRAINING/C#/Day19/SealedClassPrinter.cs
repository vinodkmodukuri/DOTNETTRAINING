using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class OfficeElectronics
    {
        protected int itemID;
        protected string itemName; 
    }

    class Printer : OfficeElectronics
    {
        public float width, height, weight;
        public string model, manufacturer;
    }

    sealed class PrinterControl : Printer
    {
        public void Print()
        {
            Console.WriteLine("The printer can print only black and white");
        }

        public void Scan()
        {
            Console.WriteLine("The printer can scan, max A4 size dimensions");
        }

    }
/*    class PrinterAccess : PrinterControl //Here we can't derive from a sealed class
 *  
    { 

    }*/



    internal class SealedClassPrinter
    {

        public static void Main(string[] args)
        {
            OfficeElectronics officeElectronics = new OfficeElectronics();
            Printer printer = new Printer();
            PrinterControl control = new PrinterControl();
            control.Print();
            control.Scan();
            Console.ReadKey();
        }
    }
}
