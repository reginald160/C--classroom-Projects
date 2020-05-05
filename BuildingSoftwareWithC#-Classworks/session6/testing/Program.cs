using System;

namespace testing {
    class Program {
        static void Main (string[] args) {
            Grade grade = new Grade ();
            // int[][] grades = new int[3][];
            // grades[0] = new int[] { 45, 60, 60 };
            // grades[1] = new int[] { 45, 60, 60 };
            // grades[2] = new int[] { 45, 60, 60 };
            // grade.DisplayGrade (grades);
            sumNum ();
        }

        static void sumNum (params int[] num) {
            int sum = 0;
            foreach (var n in num) {
                sum = sum + n;
            }
            Console.Write ($"The sum of nums is {sum} ");
        }
    }
}