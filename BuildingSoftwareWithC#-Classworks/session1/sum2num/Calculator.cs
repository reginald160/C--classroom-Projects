namespace sum2num
{
    public class Calculator
    {
        private double Num1;
        private double Num2;

        public double getNum1(){
            return Num1;
        }

        public double getNum2()
        {
            return Num2;
        }

        public void setNum(double num1, double num2){
            Num1 = num1;
            Num2 = num2;
        }

        public double add(){
            return Num1 + Num2;
        }

        public double sub()
        {
            return Num1 - Num2;
        }

        public double divide()
        {
            if (Num2 == 0)
            {
                return 0.0;
            }
            return Num1 / Num2;
        }

        public double mult()
        {
            return Num1 * Num2;
        }
    }
    
}