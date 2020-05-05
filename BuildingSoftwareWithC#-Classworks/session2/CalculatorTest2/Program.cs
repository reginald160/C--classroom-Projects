using System;

namespace CalculatorTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.Write("Please enter number 1: ");
            calculator.Num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPlease enter number 2: ");
            calculator.Num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"\nThe sum of {calculator.Num1} and {calculator.Num2} is {calculator.add()}");
            Console.Write($"\nThe difference of {calculator.Num1} and {calculator.Num2} is {calculator.sub()}");
        }
    }
}
