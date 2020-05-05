namespace GenericConstraint
{
    public class GenericClass<T> where T : class
    {
        T[] data;
        int size = 5;
        int numElements = 0;

        public GenericClass()
        {
            data = new T[ size ];
        }   

        public void Add(T item)
        {
            if (numElements < data.Length)
            {
                data[numElements] = item;
                numElements++;
            } else {
                throw new System.Exception("Collection is full!");
            }
        }

        public T Remove()
        {
            if (numElements != 0)
            {
                T item = data[--numElements];
                return item;
            }
        }

        public T[] GetAllUsers()
        {
            if (numElements > 0)
            {
                return data;
            } else {
                throw new System.Exception("Collection is empty!");
            }
        }
    }
}