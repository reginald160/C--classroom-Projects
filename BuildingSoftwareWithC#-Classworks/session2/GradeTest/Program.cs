using System;

namespace GradeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade studentGrade = new Grade();
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            studentGrade.setName(name);

            Console.Write("Please enter your score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            studentGrade.setScore(score);

            Console.Write($"Your grade is {studentGrade.getScore()}");


        }
    }
}
