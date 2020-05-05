using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "James Stuart";
            human.Age = 35;
            human.Address = "No 5, Faith Way, Ota, Ogun State.";

            Console.Write($"Name is {human.Name}");
            Console.Write($"Age is {human.Age}");
            Console.Write($"And address is {human.Address}\n");
        }
    }
}
