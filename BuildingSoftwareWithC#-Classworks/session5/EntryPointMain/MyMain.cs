using System;

namespace EntryPointMain
{
    public class MyMain
    {
        public string Name {get; set;}
        public MyMain(string name)
        {
            Name = name;
        }

        public static void sayHi(){
            Console.WriteLine("Hi... How are you!");
        }

        static void Main(){
            sayHi();
        }
    }
}