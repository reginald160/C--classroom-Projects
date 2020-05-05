namespace AccountTest
{
    public class Account
    {
        private string name = "Abayomi";

        public string getName(){
            return name;
        }

        public void setName(string Name){
            name = Name.ToUpper();
        }
    }
}