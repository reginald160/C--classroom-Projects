using System;
using System.Collections.Generic;
namespace PolymorphismTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Dog");
            Cow cow = new Cow("Cow");
            Cat cat = new Cat("Cat");
            Lion lion = new Lion("Lion");


            List<IAnimal> animals = new List<IAnimal>(){dog, cow, cat, lion};

            foreach (IAnimal animal in animals)
            {
                animal.eat();
                animal.sayHi();
                if (animal is Dog)
                {
                    Dog myDog = animal as Dog;
                    myDog.Bark();
                }
            }

        }
    }
}
