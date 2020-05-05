using System;

namespace MaximumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Finder Method!");
            double num1, num2, num3;

            Console.Write("Please enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPlease enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPlease enter third number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            double maximum = MaximumNum(num1, num2, num3);

            Console.WriteLine($"The largest of the three numbers is {maximum}");
        }

        static double MaximumNum(double Num1, double Num2, double Num3){
            double largest = Num1;
            if (Num2 > largest)
            {
                largest = Num2;                
            }

            if (Num3 > largest)
            {
                largest = Num3;
            }
            return largest;
        }
    }
}
