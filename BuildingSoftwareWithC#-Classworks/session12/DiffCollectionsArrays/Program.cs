using System;
using System.Collections;

namespace DiffCollectionsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);
            arr.Add(8);
            arr.Add(5);
            arr.Add(7);
            arr.Add(8);
            arr.Add(5);
            arr.Add(5);

            int[] num = new int[3];

            Console.WriteLine($"Capaicity: {arr.Capacity}\nNumber of Items Stored: {arr.Count}");
        }
    }

}
