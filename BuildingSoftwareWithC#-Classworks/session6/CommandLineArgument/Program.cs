using System;

namespace CommandLineArgument {
    class Program {
        static void Main (string[] args) {
            ArrayList myArray = new ArrayList ();

            myArray.Add ("Ifeanyi");
            myArray.Add ("SOJ");
            myArray.Add ("Michael");
            myArray.Add ("Abayomi");

            for (int i = 0; i < myArray.Count; i++)
            {
                Console.Write($"Item {i+1}: {myArray[i]}");
            }

        }
    }
}