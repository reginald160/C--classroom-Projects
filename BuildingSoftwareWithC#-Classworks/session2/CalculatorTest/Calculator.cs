namespace CalculatorTest
{
    public class Calculator
    {
        private double num1;
        private double num2;
        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double add(){
            return num1 + num2;   
        }

        public double sub()
        {
            return num1 - num2;
        }

        public double mult()
        {
            return num1 * num2;
        }

        public double divide()
        {
            if (num2 == 0)
            {
                return 0.0;
            }
            return num1 / num2;
        }

        

    
        
    }
}