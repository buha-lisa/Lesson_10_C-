
namespace cs10
{
    internal class Stack<T>
    {
        private int _size; 
        private T[] _data;
        private int _stackMaxSize; 
        public Stack(int stackMaxSize)
        {
            _data = new T[stackMaxSize];
            _size = 0;
            _stackMaxSize = stackMaxSize;
        }
        public int Count()
        {
            return _size;
        }

        public void Push(T item)
        {
            if (_size == _stackMaxSize)
            {
                RebuildData();
            }

            _data[_size] = item;
            _size++;
        }

        public T Peek()
        {
            if (Count() == 0)
            {
                Console.WriteLine("Stack is empty!");
            }

            return _data[_size - 1];
        }

        public T Pop()
        {
            var item = Peek();
            _size--;
            return item;
        }

        private void RebuildData()
        {
            var newData = new T[_stackMaxSize];
            for (var i = 1; i < _data.Length; i++)
            {
                newData[i - 1] = _data[i];
            }

            _data = newData;
            _size = _stackMaxSize - 1;
        }
    }
}
