namespace GenericQueueTest
{
    public class Queue<T>
    {
        private T[] data;
        private int head = 0;
        private int tail = 0;
        int numElement = 0;
        const int DEFAULTSIZE = 10;

        public Queue()
        {
            data = new T[ DEFAULTSIZE ];
        }

        public Queue( int size)
        {
            data = new T[size];
        }

        public void Enqueue(T item)
        {
            if (numElement < data.Length)
            {
                data[ head ] = item;
                head++;
                head %= data.Length;
                numElement++;
            } else {
                throw new System.Exception("Queue is full!");
            }
        }

        public T Dequeue()
        {
            if ( numElement != 0 )
            {
                T item = data[ tail ];
                tail++;
                tail %= data.Length;
                numElement--;
                return item;
            } else {
                throw new System.Exception("Queue is empty!");
            }
        }


    }
}