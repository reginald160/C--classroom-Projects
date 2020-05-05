using System;
namespace StaticTest
{
    public class Student
    {
        public static int Counter { get; set; }
        public string Name { get; set; }

        public Student()
        {
            Counter = Counter + 1;
            Console.WriteLine($"Constructor called and 1 added to Counter... {Counter}");
        }


    }
}