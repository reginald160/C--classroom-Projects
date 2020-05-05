using System;
namespace ConstructorTest
{
    public class Person
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }   
        public int Age { get; set; }

        public Person(string firstname, string lastname, int age){
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Console.WriteLine("All instance variables initialized!!!!");
        }
    }
}