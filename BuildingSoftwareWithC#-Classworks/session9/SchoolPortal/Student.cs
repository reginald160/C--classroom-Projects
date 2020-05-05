using System;
using System.Collections.Generic;

namespace SchoolPortal {
    public abstract class Student {
        public string Name { get; set; }
        public int RegNum { get; set; }
        protected int[] scores;
        protected List<string> courses;

        public Student (string theName, int regNum) {
            Name = theName;
            RegNum = regNum;
            scores = new int[3];
        }

        public void GetScores () {
            int counter = 0;
            foreach (var course in courses) {
                Console.Write ($"Please enter score for {course}: ");
                scores[counter] = Convert.ToInt32 (Console.ReadLine ());
                counter++;
            }
        }

        public int FindAverage () 
        {
            int sum = 0;
            foreach (var score in scores) {
                sum = sum + score;
            }

            return sum / scores.Length;
        }
    }

    public class CommercialStudent : Student {
        public CommercialStudent (string name, int regnum) : base (name, regnum) {
            courses = new List<string> () { "Electronic Circuits", "Circuit Analysis", "Analog Communication" };
            GetScores ();
        }

        public override string ToString () {
            return $"======= Result Analysis: {Name} ========\nElectronic Circuits:\t{scores[0]}\nCircuit Analysis:\t{scores[1]}\nAnalog Communication:\t{scores[2]}\n\nAverage Score:\t{FindAverage()}";
        }
    }

    public class ScienceStudent : Student {
        public ScienceStudent (string name, int regnum) : base (name, regnum) {
            courses = new List<string> () { "Computer Network", "Data Structure", "Introduction to C#" };
            GetScores ();
        }

        public override string ToString () {
            return $"======= Result Analysis: {Name} ========\nComputer Network:\t{scores[0]}\nData Structure:\t{scores[1]}\nIntroduction to C#:\t{scores[2]}\n\nAverage Score:\t{FindAverage()}";
        }
    }

}