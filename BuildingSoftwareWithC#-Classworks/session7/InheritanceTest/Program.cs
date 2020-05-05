using System;

namespace InheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;
            car = new Car();

            car.Move();
            car.Stop();
        }
    }
}
