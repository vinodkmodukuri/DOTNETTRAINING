using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Animal1
    {
        public virtual void FoodHabits()
        {
            Console.WriteLine("All the animals have diffferent food habits");
        }

    }

    class Herbivores: Animal1
    {
        public override void FoodHabits()
        {
            Console.WriteLine("These animals eat only plants");
        }
    }

    class Carnivores: Animal1
    {
        public override void FoodHabits()
        {
            Console.WriteLine("These animals eat only eat meat");
        }
    }

    class implement
    {
        public void FunctionCall(Animal1 myanimal)
        {
            myanimal.FoodHabits();

        }
    }
    internal class VirtualFunctions
    {

        public static void Main(string[] args)
        {

            implement myobj1 = new implement();
            Herbivores myobj2 = new Herbivores();
            Carnivores myobj3 = new Carnivores();
            myobj2.FoodHabits();
            myobj1.FunctionCall(myobj3);

            Console.ReadKey();
        }
    }
}
