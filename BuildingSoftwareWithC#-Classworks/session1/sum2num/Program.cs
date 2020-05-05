using System;

namespace sum2num
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            double num1, num2;
            Console.Write("Please enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            myCalculator.setNum(num1, num2);

            Console.Write($"The sum of the two numbers is {myCalculator.add()}\n");
            Console.Write($"The product of the two numbers is {myCalculator.mult()}\n");
            Console.Write($"The quotient of the two numbers is {myCalculator.divide()}\n");
            Console.Write($"The difference of the two numbers is {myCalculator.sub()}\n");
        }   
    }
}
