namespace ElectorateTest {
    public class Electorate {
        public string Name { get; set; }
        private int age;

        public Electorate (string name, int userAge) {
            Name = name;
            Age = userAge;
        }
        public int Age 
        {
            get { return age; }

            set {
                if (value > 0) {
                    age = value;
                }
            }
        }

        public string checkEligibility(){
            if(Age < 18){
                return "Not eligibible to vote!";
            } else {
                return "Eligible to vote!";
            }
        } 

    }
}