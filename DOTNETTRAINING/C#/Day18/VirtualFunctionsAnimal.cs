using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Animal2
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("All the animals have generic sound");
        }
    }

    class Cat : Animal2
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cats make Meow sound");
        }
    }

    class Dog1 : Animal2
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dogs Bark");
        }
    }

   class AnimalHandler
    {
        public void MakeAnimalSpeak(Animal2 animal)
        {
            animal.MakeSound();
        }
    }

    internal class VirtualFunctionsAnimal
    {
        public static void Main(string[] args)
        {
            Animal2 animal3 = new Animal2();
            Dog1 dog2 = new Dog1();
            Cat cat2 = new Cat();
/*          animal3.MakeSound();
            dog2.MakeSound();
            cat2.MakeSound();
*/
            AnimalHandler myanimal = new AnimalHandler();
            myanimal.MakeAnimalSpeak(dog2);
            myanimal.MakeAnimalSpeak(cat2);
            Console.ReadLine();
        }
    }
}

