using System;
namespace GradeBookTest2 {
    public class GradeBook {
        private string CourseName { get; set; }
        private int[, ] grades;

        public GradeBook (string coursename, int[, ] Grades) {
            CourseName = coursename;
            grades = Grades;
        }

        public void DisplayDetails () {
            Console.WriteLine ($"CSC 101 Result for Class A - {CourseName}");
        }

        public void ProcessGrade () {
            DisplayGrades ();

            Console.WriteLine ($"The lowest grade is {GetMinimum()}");
            Console.WriteLine ($"The highest grade is {GetMaximum()}");
            //Console.WriteLine ($"The lowest grade is {GetMinimum()}");

        }

        private int GetMinimum () {
            int lowest = grades[0, 0];

            foreach (int grade in grades) {
                if (grade < lowest) {
                    lowest = grade;
                }
            }

            return lowest;
        }

        private int GetMaximum () {
            int highest = grades[0, 0];

            foreach (int grade in grades) {
                if (grade > highest) {
                    highest = grade;
                }
            }

            return highest;
        }

        private void DisplayGrades () {
            double[] ave;
            ave = GetAverage ();
            for (int i = 0; i < grades.GetLength (0); i++) {
                double total = 0.0;
                Console.Write ($"Student {i+1,3} ");
                for (int k = 0; k < grades.GetLength (1); k++) {
                    total += grades[i, k];
                    Console.Write ($"{grades[i,k],2}\t");
                }
                double average = total / grades.GetLength (1);
                Console.Write ($"{average:0.00} new ave: {ave[i]:0.00}");
                Console.WriteLine ();
            }
        }

        private double[] GetAverage () {
            double[] average = new double[grades.GetLength (0)];
            double total;

            for (int i = 0; i < grades.GetLength (0); i++) {
                total = 0.0;
                for (int k = 0; k < grades.GetLength (1); k++) {
                    total += grades[i, k];
                }
                average[i] = total / grades.GetLength (1);
            }

            return average;
        }
    }
}