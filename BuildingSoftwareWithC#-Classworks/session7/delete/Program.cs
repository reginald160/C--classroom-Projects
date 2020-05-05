using System;

namespace delete
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
        }
    }


    class Animal
    {
        public Animal()
        {
            Console.WriteLine("ANimal Constructor called");
        }
    }

    class Dog:Animal
    {
        
    }
}
