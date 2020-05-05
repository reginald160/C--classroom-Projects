using System;
namespace InheritanceTest
{
    public class Automobile
    {
        public int NumWheels { get; set; }
        public string Colour { get; set; }  
        public int YearManu { get; set; }   
        public string Model { get; set; }   
        public string Manufacturer { get; set; }

        public Automobile()
        {
            // NumWheels = nw;
            // Colour = col;
            // YearManu = year;
            // Model = mod;
            // Manufacturer = man;
            Console.WriteLine("Automobile constructor called!");
        }

        public virtual void Move(){
            Console.WriteLine("Automobile is moving!!!");
        }

        public virtual void Stop(){
            Console.WriteLine("Automobile has stopped!");
        }
    }

    class Car:Automobile
    {
        public override void Move(){
            Console.WriteLine("Car is moving!!!");
        }

        public override void Stop()
        {
            Console.WriteLine("Car has stopped!!!");
        }
    }
}