namespace GenericMethodTest
{
    public class Numbers
    {
        public T Add<T>(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return a1 + b1;
        }
    }
}