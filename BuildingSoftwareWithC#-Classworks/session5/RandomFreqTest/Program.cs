using System;

namespace RandomFreqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int frequency1 = 0;
            int frequency2 = 0;
            int frequency3 = 0;
            int frequency4 = 0;
            int frequency5 = 0;
            int frequency6 = 0;

            long count = 60000000;

            for (long i = 1; i <= count; i++)
            {
                int face = random.Next(1, 7);

                switch (face)
                {
                    case 1: 
                        frequency1++;
                        break;
                    case 2: 
                        frequency2++;
                        break;
                    case 3:
                        frequency3++;
                        break;
                    case 4:
                        frequency4++;
                        break;
                    case 5:
                        frequency5++;
                        break;
                    case 6: 
                        frequency6++;
                        break;
                    default:
                    break;
                }
            }
            // Create Output Header
            Console.Write($"Face\tFrequency\n");

            Console.Write($"1\t{frequency1}\n");
            Console.Write($"2\t{frequency2}\n");
            Console.Write($"3\t{frequency3}\n");
            Console.Write($"4\t{frequency4}\n");
            Console.Write($"5\t{frequency5}\n");
            Console.Write($"6\t{frequency6}\n");  
        }
    }
}
