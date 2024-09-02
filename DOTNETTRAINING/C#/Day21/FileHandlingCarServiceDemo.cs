using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program1
{
    internal class FileHandlingCarServiceDemo
    {
        public void CarServiceWrite()
        {
            FileStream fsWrite = new FileStream("carService.xlsx", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fsWrite);

            string VIN, date;
            Console.WriteLine("Enter the today's in dd/mm/yyyy format");
            date = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the the Car VIN Number");
            VIN = Convert.ToString(Console.ReadLine());
            
            int mileage, amount;
            Console.WriteLine("Enter the car Mileage");
            mileage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the amount"); 
            amount = Convert.ToInt32(Console.ReadLine());

            streamWriter.WriteLine(VIN);
            streamWriter.WriteLine(date);
            streamWriter.WriteLine((int)mileage);
            streamWriter.WriteLine((int)amount);

            streamWriter.Close();
            fsWrite.Close();
        }

        public void CarServiceRead()
        {
            FileStream fsRead = new FileStream("carService.xlsx", FileMode.Open, FileAccess.Read);
            
            StreamReader streamReader = new StreamReader(fsRead);

            string str = streamReader.ReadLine();

            while (str != null)
            {
                Console.WriteLine("The car service details are: {0}", str);
                str = streamReader.ReadLine();
            }
            streamReader.Close();
            fsRead.Close();

        }
        public static void Main(string[] args)
        {
            
            FileHandlingCarServiceDemo fileHandlingCarServiceDemo = new FileHandlingCarServiceDemo();
            

            fileHandlingCarServiceDemo.CarServiceWrite();
            fileHandlingCarServiceDemo.CarServiceRead();

            Console.ReadKey();
        }


    }
}

