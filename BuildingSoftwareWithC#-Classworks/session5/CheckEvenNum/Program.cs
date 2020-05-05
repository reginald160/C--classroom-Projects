using System;

namespace CheckEvenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program Contains a Method that Scans numbers from 1 to 10 for even numbers....");

            for (int i = 1; i <= 10; i++)
            {
                
                if (checkEvenNum(i))
                {
                    Console.WriteLine($"{i} (even number)");
                    continue;
                }
                Console.WriteLine(i);
                
            }
        }

        static bool checkEvenNum(int num){
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
