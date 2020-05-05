using System;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Num1 = 45;
            calculator.Num2 = 34;

            Console.Write($"Calling add method returns: {calculator.add()}\n");
            Console.Write($"Calling sub method returns: {calculator.sub()}\n");
            Console.Write($"Calling mult method returns: {calculator.mult()}\n");
            Console.Write($"Calling divide method returns: {calculator.divide()}");
        }
    }
}
