using System;

namespace Scope
{
    class Program
    {
        private static int x = 1;
        static void Main(string[] args)
        {
            int x = 5;

            Console.WriteLine($"x in the main method is {x}");

            UseLocalVariable();

            UseStaticVariable();

            UseLocalVariable();

            UseStaticVariable();
        }

        static void UseLocalVariable(){
            int x = 25;
            Console.WriteLine($"x in UseLocalVariable Method is {x}");
        }

        static void UseStaticVariable()
        {
            x = x + 25;
            Console.WriteLine($"x in UseStaticVariable Method is {x}");
        }
    }
}
