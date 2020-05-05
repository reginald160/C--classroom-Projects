namespace StudentTest {
    public class Student {
        public string Name { get; set; }
        private int average;

        public Student (string name, int ave) {
            Name = name;
            Average = ave;
        }

        public int Average {
            get {
                return average;
            }
            set {
                if (value > 0) {
                    average = value;
                }
            }
        }

        public string LetterGrade {
            get {
                string letterGrade = string.Empty;
                if (Average >= 90) {
                    letterGrade = "A";
                } else if(Average >= 80){
                    letterGrade = "B";
                } else if(Average >= 70){
                    letterGrade = "C";
                } else if(Average >= 60){
                    letterGrade = "D";
                } else {
                    letterGrade = "F";
                }
                return letterGrade;
            }
        }

    }
}