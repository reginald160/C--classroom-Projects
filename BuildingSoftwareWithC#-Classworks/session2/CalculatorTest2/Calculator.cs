namespace CalculatorTest2
{
    public class Calculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double add(){
            return Num1 + Num2;
        }

        public double sub()
        {
            return Num1 - Num2;
        }
    }
}