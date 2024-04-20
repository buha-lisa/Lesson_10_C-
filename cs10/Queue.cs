namespace cs10
{
    internal class Queue<T>
    {
        private T[] _data;
        private int _head; 
        private int _tail;

        public Queue(int size)
        {
            _data = new T[size];
            _head = 0;
            _tail = 0;
        }

        public void Enqueue(T item)
        {
            if (_tail == _data.Length)
            {
                Console.WriteLine("Queue is full");
            }

            _data[_tail++] = item;
        }
        public T Dequeue()
        {
            if (_head == _tail)
            {
                Console.WriteLine("Queue is empty");
            }

            T item = _data[_head];
            _head++;
            return item;
        }
        public T Peek()
        {
            if (_head == _tail)
            {
                Console.WriteLine("Queue is empty");
            }

            return _data[_head];
        }
        public int Count()
        {
            return _tail - _head;
        }
    }
}
