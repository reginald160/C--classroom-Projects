using System;

namespace StaticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();

            Console.WriteLine($"The student class has been instantiated {Student.Counter} times.");
        }
    }
}
