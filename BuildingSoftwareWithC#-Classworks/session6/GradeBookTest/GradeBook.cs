using System;

namespace GradeBookTest {
    public class GradeBook {
        private string CourseName { get; }
        public int[] Grades;

        public GradeBook (int[] grades, string courseName) {
            CourseName = courseName;
            Grades = grades;
        }

        public void DisplayDetails () {
            Console.WriteLine ($"Results of {CourseName}!");
        }

        public void ProcessGrades () {
            OutputGrades ();

            Console.WriteLine ($"The lowest grade is {GetMinimum()}");
            Console.WriteLine ($"The highest grade is {GetMaximum()}");

            Console.WriteLine ($"The average grade is {GetAverage():F}");
        }

        private void OutputGrades () {
            int count = 1;
            foreach (int grade in Grades) {
                Console.WriteLine ($"Student{ count,2} {grade,4}");
                count++;
            }
        }

        private int GetMinimum () {
            int lowest = Grades[0];
            for (int i = 1; i < Grades.Length; i++) {
                if (Grades[i] < lowest) {
                    lowest = Grades[i];
                }
            }
            return lowest;
        }

        private int GetMaximum () {
            int highest = Grades[0];
            for (int i = 1; i < Grades.Length; i++) {
                if (Grades[i] > highest) {
                    highest = Grades[i];
                }
            }

            return highest;
        }

        private double GetAverage () 
        {
            double sum = 0.0;
            foreach (int grade in Grades) {
                sum += grade;
            }

            double average = sum / Grades.Length;
            return average;
        }

        public override string ToString(){
            return "Course name is " + CourseName;
        }
    }
}