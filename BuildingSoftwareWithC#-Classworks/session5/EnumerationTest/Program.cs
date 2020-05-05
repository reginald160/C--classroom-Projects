using System;

namespace EnumerationTest
{
    class Program
    {  
        public enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday = 10,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.Write($"{(int)Day.Sunday}");
        }
    }
}
