namespace cs10
{
    public class Box<T>
    {
        public T Value { get; set; }
        private T _content;
        public Box(T content)
        {
            _content = content;
        }
        public T GetContent() => _content;
    }
}
