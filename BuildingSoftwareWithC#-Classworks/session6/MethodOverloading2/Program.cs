using System;

namespace MethodOverloading2
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            int x = 7;
            float y = 4.5;
            number.checkNum(x, y);
        }
    }
}
