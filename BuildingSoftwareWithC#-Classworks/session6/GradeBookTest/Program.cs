using System;

namespace GradeBookTest {
    class Program {
        static void Main (string[] args) {
            int[] grades = { 56, 78, 89, 79, 67, 90, 50, 80, 86, 88 };

            GradeBook gradebook = new GradeBook (grades, "Building Applications with C#");

            // gradebook.DisplayDetails();

            // gradebook.ProcessGrades();
            int num = 10;
            Console.WriteLine (Convert.ToString (num));
        }
    }
}