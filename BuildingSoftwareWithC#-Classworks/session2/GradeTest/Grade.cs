namespace GradeTest
{
    public class Grade
    {
        public string name;
        private int gradeScore;

        public string getName(){
            return name;
        }

        public void setName(string Name){
            name = Name;
        }

        public string getScore(){
            if (gradeScore >= 70)
            {
                return "A";
            } else if(gradeScore >= 60 && gradeScore < 70){
                return "B";
            } else if(gradeScore >= 55 && gradeScore < 60){
                return "C";
            } else {
                return "D";
            }
        }

        public void setScore(int Score){
            gradeScore = Score;
        }
    }
}