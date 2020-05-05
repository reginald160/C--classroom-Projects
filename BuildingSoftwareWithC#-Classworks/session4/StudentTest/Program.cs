using System;

namespace StudentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("James", 80);
            Console.Write($"{student.Name}'s letter grade is {student.LetterGrade}");
        }
    }
}
