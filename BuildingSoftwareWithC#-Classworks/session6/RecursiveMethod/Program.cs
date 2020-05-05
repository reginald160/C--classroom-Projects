using System;

namespace RecursiveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static long Factorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
    }
}
