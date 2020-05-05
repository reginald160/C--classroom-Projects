using System;

namespace test2 {
    class Program {
        static void Main (string[] args) {
            Time1 time = new Time1 ();
            time1.SetTime(5,7,45);
            Time1 time2 = new Time1 (time);

            Console.WriteLine ("The standard time from time2 obj is: ");
            Console.WriteLine (time.ToString () + "\n");

            // Display initial values
            Console.WriteLine ("The initial universal time is: ");
            Console.WriteLine (time.ToUniversalString () + "\n");
            Console.WriteLine ("The initial standard time is: ");
            Console.WriteLine (time.ToString () + "\n");

            time.SetTime (16, 15, 34);

            Console.WriteLine ("The initial universal time is: ");
            Console.WriteLine (time.ToUniversalString () + "\n");
            Console.WriteLine ("The initial standard time is: ");
            Console.WriteLine (time.ToString () + "\n");

            try {
                time.SetTime (999, 99, 9);
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine (e.ParamName);
            }
        }
    }
}