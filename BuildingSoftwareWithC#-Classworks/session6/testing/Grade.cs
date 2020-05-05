using System;

namespace testing
{
    public class Grade
    {
       // private int[,] Grades;

        public void DisplayGrade(int[][] grades){
            foreach (var item in grades)
            {
                Console.WriteLine($"{item}\n");   
            }
        }
    }
}