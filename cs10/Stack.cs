
namespace cs10
{
    internal class Stack<T>
    {
        private int _top;
        private int _size;
        private T[] _data;
        private void resizeAndCopy()
        {
            T[] valueArr = new T[_size];
            for (int i = 0; i < _top; ++i)
            {
                valueArr[i] = _data[i];
            }
            Array.Clear(_data, 0, _size);
            _data = valueArr;
        }
        public Stack(int size)
        {
            _size = size;
            _data = new T[size];
            _top = -1;
        }

        public void Push(T item) 
        {
            if (_top == _size-1) 
            {
                Console.WriteLine("Stack is full!");
            }
            else
            {
                _data[_top++] = item;
            }
        }
        public T Pop() 
        {   
            if ( _top == -1)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                _data[_top] = _data[_top--];
                if (_top <= _size / 3)
                {
                    _size = _size * 2 / 3;
                    resizeAndCopy();
                }
            }
            return _data[_top];
        }
        public T Peek()
        {
            if (_top == -1)
            {
                Console.WriteLine("Stack is empty!");
            }
            return _data[_top];
        }

        public int Count()
        {
            return _size;
        }

        public void Show()
        {
            foreach (Object obj in _data)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
