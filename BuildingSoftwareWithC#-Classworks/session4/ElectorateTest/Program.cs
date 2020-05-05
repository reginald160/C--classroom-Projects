using System;

namespace ElectorateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Electorate electorate = new Electorate("James Stuart", -45);
            Console.WriteLine($"{electorate.Name} is {electorate.checkEligibility()}");
        }
    }
}
