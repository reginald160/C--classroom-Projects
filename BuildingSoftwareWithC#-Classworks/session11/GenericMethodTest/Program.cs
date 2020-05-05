using System;

namespace GenericMethodTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            double num1 = 50.5;
            double num2 = 30.5;
            double result = numbers.Add<double>(num1, num2);

            Console.WriteLine($"{result}");
        }
    }
}
