using System;

namespace GenericQueueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Generic Queue for string value type
            Queue<string> queue1 = new Queue<string>(3);
            queue1.Enqueue("James Stuart");
            queue1.Enqueue("Ifeanyi Ozougwu");
            queue1.Enqueue("Abayomi Igwubor");

            Console.WriteLine($"{queue1.Dequeue()}");
            Console.WriteLine($"{queue1.Dequeue()}");
            Console.WriteLine($"{queue1.Dequeue()}");

            Queue<int> queue2 = new Queue<int>(4);
            queue2.Enqueue(10);
            queue2.Enqueue(20);
            queue2.Enqueue(30);

            Console.WriteLine("Queue containing int type values....");
            Console.WriteLine($"{queue2.Dequeue()}");
            Console.WriteLine($"{queue2.Dequeue()}");
            Console.WriteLine($"{queue2.Dequeue()}");

            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            Queue<Circle> queue3 = new Queue<Circle>(2);
            queue3.Enqueue(circle1);
            queue3.Enqueue(circle2);

            Console.WriteLine("Queue containing complex type (Class objects)....");
            Console.WriteLine($"{queue3.Dequeue()}");
            Console.WriteLine($"{queue3.Dequeue()}");
            try
            {
                Console.WriteLine($"{queue3.Dequeue()}");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Queue is empty!!!");
            }

        }
    }
}
