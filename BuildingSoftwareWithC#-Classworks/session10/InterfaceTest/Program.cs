using System;
using System.Collections.Generic;

namespace InterfaceTest {
    class Program {
        static void Main (string[] args) {
            Rectangle rectangle = new Rectangle (5.0, 6.0);
            Circle circle = new Circle (8.0);

            double area = rectangle.CalculateArea ();

            Console.WriteLine ($"The area of the rectangle is: {area}");

            Console.WriteLine ($"The area of the circle is: {circle.CalculateArea()}");

            // Processing shapes polymorphically....
            Console.WriteLine ("Processing shapes polymorphically....");

            List<IShape> shapes = new List<IShape> () { rectangle, circle };

            foreach (var shape in shapes) {
                //Console.WriteLine ($"{shape.DisplayDetails()}");
                Console.WriteLine ($"Area is {shape.CalculateArea()}");
            }
        }
    }
}