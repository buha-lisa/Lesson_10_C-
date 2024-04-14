namespace cs10
{
    internal class Car
    {
        public int HorsePower { get; set; }
        public Car() { }



        public void Test<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
