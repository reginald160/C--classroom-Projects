using System;

namespace SchoolPortal {
    class Program {
        static void Main (string[] args) {
            string dept;
            int RegNum;
            string name;

            Console.Write ("Please enter your name: ");
            name = Console.ReadLine ();

            Console.Write ("Please enter your registration number: ");
            RegNum = Convert.ToInt32 (Console.ReadLine ());

            Console.Write ("Please enter your department: ");
            dept = Console.ReadLine ();

            if (dept == "SCI") {
                Student scienceStudent = new Student (name, RegNum);
                Console.WriteLine(scienceStudent);
            } else if (dept == "COMM") {
                CommercialStudent commercialStudent = new CommercialStudent (name, RegNum);
                Console.WriteLine( commercialStudent.ToString() );
            } else {
                Console.WriteLine("Invalid entry!!! Please try again.");
            }

        }
    }
}