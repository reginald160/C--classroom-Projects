using System;

namespace Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            long[] frequency = new long[6];

            for (long i = 1; i < 60000000; i++)
            {
                int face = random.Next(1, 7);
                frequency[face-1]++;
            }

            Console.WriteLine($"Face\tFrequency");
            int count = 1;
            foreach (long item in frequency)
            {
                Console.Write($"\n{count,5} {item,12}");
                count++;
            }
            
        }
    }
}
