using System;

namespace MethodOverloading
{
    public class Student
    {
        public string Name { get; set; }    

        public Student(string name)
        {
            Name = name;
        }

        public void greetUser(){
            Console.WriteLine($"Good afternoon {Name}");
        }

        public void greetUser(string name)
        {
            Console.WriteLine($"Good afternoon {name}");
        }

        public string greetUser(string name)
        {
            return "Good afternoon {name}";
        }
    }
}