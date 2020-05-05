using System;

namespace ClassAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====A program to find the average score of 10 students=====!");
            int grade = 0;
            int sum = 0;
            int counter = 0;
            double average = 0.0;
             
            int x = average;

            while (counter < 10)
            {
                Console.Write($"Enter grade {counter + 1}: ");
                grade = Convert.ToInt32(Console.ReadLine());
                sum = sum + grade;
                counter++;
            }

            average = sum / counter; // Integer division always returns an integer.

            Console.WriteLine($"Total of all 10 grades is {sum}");
            Console.Write($"Class average is {average}");
        }
    }
}
