using System;

namespace welcome1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");
        }
    }
}
