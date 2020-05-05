namespace InterfaceTest {
    public class Rectangle : IShape , IDetails
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rectangle (double len, double brd) {
            Length = len;
            Breadth = brd;
        }

        public double CalculateArea () {
            return Length * Breadth;
        }

        public string DisplayDetails () {
            return $"This is a Rectangle!";
        }
    }
}