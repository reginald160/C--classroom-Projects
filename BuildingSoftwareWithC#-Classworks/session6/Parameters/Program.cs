using System;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int num2 = 5;
            int num3;

            Add5(num);
            Add5ByRef(ref num2);
            Add5ByOut(out num3);

            Console.WriteLine($"The value of num passed by value is {num}");
            Console.WriteLine($"The value of num2 passed by ref is {num2}");
            Console.WriteLine($"The value of num3 passed by out is {num3}");
        }

        private static void Add5(int n)
        {
            n = n + 5;
        }

        private static void Add5ByRef(ref int n)
        {
            n = n + 5;
        }

        private static void Add5ByOut(out int n)
        {
            n = 5;
            n = n + 5;
        }

        
    }
}
