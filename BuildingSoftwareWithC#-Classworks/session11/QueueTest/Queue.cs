namespace QueueTest
{
    public class Queue
    {
        private object[] data;
        private const int DEFAULTSIZE = 20;
        private int head = 0;
        private int tail = 0;
        private int numElements = 0;

        public Queue()
        {
            data = new object[ DEFAULTSIZE ];
        }

        public Queue(int size)
        {
            data = new object[ size ];
        }

        public void QueueItem( object item )
        {
            if (numElements < data.Length)
            {
                data[ head ] = item;
                head++;
                head = head % data.Length;
                numElements++;
            } else {
                throw new System.ArgumentOutOfRangeException("Queue is full...");
            }
        }

        public object DeQueueItem()
        {
            if ( numElements != 0 )
            {
                object item = data[ tail ];
                tail++;
                tail = tail % data.Length;
                numElements--;
                return item;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Queue is empty...");
            }
        }

        
    }
}