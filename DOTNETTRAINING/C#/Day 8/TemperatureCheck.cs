using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class TemperatureCheck
    {
        public static void Main(string[] args)
        {
            int temperature;
            Console.WriteLine("Enter the temperature");
            temperature=Convert.ToInt32(Console.ReadLine());
            int max_temp = 30;
            int min_temp = 10;

            if (temperature > max_temp)
            {
                Console.WriteLine("Too hot");
            }
            else if (temperature < min_temp)
            {
                Console.WriteLine("Too cold");
            }
            else if (temperature >= min_temp  || temperature <=max_temp)
            {
                Console.WriteLine("Just right");
            }
            else
            {
                Console.WriteLine("Invalid temperature ");
            }
            Console.ReadLine();

        }

    }
}

