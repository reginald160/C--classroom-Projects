using System;

namespace StandardDeviation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"A Program to Find the Standard Deviation of a Distribution");
            Console.Write("Enter the total number of items in your distribution: ");
            int ArrayLength = Convert.ToInt32(Console.ReadLine());
            double[] dist = new double[ArrayLength];

            double sum = 0.0, mean;

            for (int i = 0; i < dist.Length; i++)
            {
                Console.Write($"\nEnter item value {i+1}: ");
                dist[i] = Convert.ToDouble(Console.ReadLine());
                sum += dist[i];
            }

            mean = sum / dist.Length;

            // Get deviations from mean

            double sumDeviations = 0.0;

            for (int i = 0; i < dist.Length; i++)
            {
                double dev = dist[i] - mean;
                sumDeviations = sumDeviations + (Math.Pow(dev,2));   
            }

            double MeanDev = sumDeviations / dist.Length;

            double SD = Math.Sqrt(MeanDev);

            Console.WriteLine($"Standard Deviation is {SD}");
        }
    }
}
