using System;

namespace GradeBookTest2 {
    class Program {
        static void Main (string[] args) {
            int[, ] grades = { { 50, 60, 70 }, { 89, 90, 70 }, { 50, 80, 60 }, { 50, 60, 70 }, { 78, 99, 70 }, { 65, 60, 60 }, { 50, 60, 70 }, { 50, 60, 70 }, { 50, 60, 70 }, { 50, 60, 70 }, };
            GradeBook gradebook = new GradeBook ("Building Software Applications With C#", grades);

            gradebook.DisplayDetails();

            gradebook.ProcessGrade();
        }
    }
}