using System;

namespace VotePoll
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contestants = {"Buhari", "Sowore", "Atiku", "Fela"};
            int[] votes = {30, 12, 20, 5};

            for (int i = 0; i < contestants.Length; i++)
            {
                Console.Write($"{contestants[i]}: ");
                int numVotes = votes[i];

                for (int k = 0; k < numVotes; k++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
            }
        }
    }
}
