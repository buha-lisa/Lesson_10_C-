namespace cs10
{
    internal class Task1_3
    {
        public T MaxValue<T>(T num1, T num2, T num3)
        {
            return new[] { num1, num2, num3 }.Max();
        }

        public T MinValue<T>(T num1, T num2, T num3)
        {
            return new[] { num1, num2, num3 }.Min();
        }

        public T SumArray<T>(T[] array)
        {
            dynamic sum = default(T);

            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
    }
}
