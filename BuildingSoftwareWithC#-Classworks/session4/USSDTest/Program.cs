using System;

namespace USSDTest {
    class Program {
        static void Main (string[] args) {
            Console.Write ("======= Welcome to Codebits Academy ========\n");
            string name, gender;

            Console.Write ("Enter your name: ");
            name = Console.ReadLine ();

            Console.Write ("\nAre you a male or female? If male enter m else enter f: ");
            gender = Console.ReadLine ();

            string title = (gender == "m") ? "Mr" : "Mrs";

            Console.WriteLine ($"Welcome {title} {name}");

        }
    }
}