using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class RationalNumbers
    {
        public int nr, dr; 

        public void Accept()
        {
            Console.WriteLine("Enter the numerator and denomiator"); 
            nr = Convert.ToInt32(Console.ReadLine());
            dr = Convert.ToInt32(Console.ReadLine());
        }
        
        public void Display()
        {
            Console.WriteLine(nr + "/" + dr);
        }

        public static RationalNumbers operator +(RationalNumbers objA, RationalNumbers objB)
        {
            RationalNumbers temp = new RationalNumbers();
            temp.nr = objA.nr * objB.dr + objA.dr * objB.nr;
            temp.dr = objA.dr * objB.dr;
            return temp;
        }
        public static void Main(string[] arg)
        {
            Console.WriteLine("First object value");
            RationalNumbers obj1 = new RationalNumbers();
            obj1.Accept();
            obj1.Display();
            Console.WriteLine("The second object value");
            RationalNumbers obj2 = new RationalNumbers();
            obj2.Accept();
            obj2.Display();

            RationalNumbers obj3 = new RationalNumbers();
            obj3 = obj1 + obj2;
            obj3.Display();
            Console.ReadKey();
        }
    }
}
