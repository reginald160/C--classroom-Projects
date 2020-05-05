namespace PolyShapes
{
    public abstract class Shapes
    {
        protected int length;
        protected int breadth;

        public abstract int Length{ get; set; }
        public abstract int Breadth { get; set; }

        public abstract int area();

        public Shapes(int thelen, int thebreadth)
        {
            Length = thelen;
            Breadth = thebreadth;
        }
    }


    public class Rectangle:Shapes
    {
        public override int Length
        {
            get{
                return length;
            }

            set{
                if (value > 0)
                {
                    length = value;
                }
            }

        }

        public override int Breadth
        {
            get
            {
                return breadth;
            }

            set
            {
                if (value > 0)
                {
                    breadth = value;
                }
            }

        }

        public override int area()
        {
            return Length * Breadth;
        }
    }
}