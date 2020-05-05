using System;

namespace ConstructorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("James", "Stuart", 37);
            Console.Write($"Person's firstname is {person.FirstName}");
            Console.Write($"Person's lastname is {person.LastName}");
            Console.Write($"Person's age is {person.Age}");
        }
    }
}
