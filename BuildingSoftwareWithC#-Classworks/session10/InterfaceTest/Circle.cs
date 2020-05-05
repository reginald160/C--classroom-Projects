using System;

namespace InterfaceTest
{
    public class Circle : IShape, IDetails
    {
        public double Radius { get; set; }  
        
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return 2 * (Math.PI * Radius * Radius);
        }

        public string DisplayDetails()
        {
            return $"This is a Circle!";
        }
    }
}