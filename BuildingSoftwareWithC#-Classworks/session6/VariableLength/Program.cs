using System;

namespace VariableLength {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ($"SumSquared called with 1 argument supplied: {SumSquare(2)}");
            Console.WriteLine ($"SumSquared called with 2 arguments supplied: {SumSquare(2, 3)}");
            Console.WriteLine ($"SumSquared called with 3 arguments supplied: {SumSquare(2, 3, 4)}");
        }

        static int SumSquare (params int[] num) {
            int sum = 0;
            foreach (int n in num) {
                int squared = n * n;
                sum = sum + squared;
            }
            return sum;
        }
    }
}