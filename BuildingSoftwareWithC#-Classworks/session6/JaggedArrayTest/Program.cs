using System;

namespace JaggedArrayTest {
    class Program {
        static void Main (string[] args) {
            
            int[][] scores = {
                new int[] { 30, 40 },
                new int[] { 5, 60, 30 },
                new int[] { 13, 12, 50, 30 }
            };

            for (int i = 0; i < scores.Length; i++) {
                for (int k = 0; k < scores[i].Length; k++) {
                    Console.Write ($"{scores[i][k],2} ");
                }
                Console.WriteLine ();
            }
        }
    }
}