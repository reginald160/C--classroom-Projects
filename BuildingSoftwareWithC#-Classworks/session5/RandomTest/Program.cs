using System;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                int face = random.Next(11);
                Console.Write($"{face} ");   
            }
        }
    }
}
