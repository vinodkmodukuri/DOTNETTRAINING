using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("All the animals required food");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("All the dogs bark");
        }

    }

    class BabyDog: Dog
    {
        public void Cry()
        {
            Console.WriteLine("Baby dogs will cry");
        }
    }

    internal class MultiLevelInheritance
    {
        public static void Main(string[] args)
        {
            BabyDog mydog = new BabyDog();
            mydog.Eat();
            mydog.Cry();
            mydog.Bark();
            Console.ReadLine();
        }
    }
}
