using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class ElectronicDevice
    {
        protected int itemID;
        protected string itemType;
    }

    sealed class TV : ElectronicDevice
    {
        protected int serialNumber;
        protected string tvModel;

        public void ItemAccept()
        {
            Console.WriteLine("Enter the item ID");
            itemID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the item type");
            Console.WriteLine("Enter the item serial number");
            serialNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the item type");
            itemType = Console.ReadLine();
            Console.WriteLine("Enter the item model");
            tvModel = Console.ReadLine();
        }

        public void ItemDisplay()
        {
            Console.WriteLine("The item ID is {0}", itemID);
            Console.WriteLine("The item type is: {0}", itemType);
            Console.WriteLine("The item serial number is : {0}", serialNumber);
            Console.WriteLine("The item model is : {0}", tvModel);
        }
    }

/*    class Laptop : TV
    {
        protected string brand;
        protected float screenSize;
    }*/


    internal class SealedClass
    {

        public static void Main(string[] args)
        {
            TV mytv = new TV();
            mytv.ItemAccept();
            mytv.ItemDisplay();
            Console.ReadKey();
        }
    }
}
