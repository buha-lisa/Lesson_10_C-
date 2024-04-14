namespace cs10
{
    internal class Program
    {
        static void Main()
        {
            var max = new Task1_3().MaxValue<int>(3, 6, 7);
            Console.WriteLine($"Max: {max}");

            var min = new Task1_3().MinValue<int>(3, 6, 7);
            Console.WriteLine($"Min: {min}");

            var stack = new Stack<int>(5);
            stack.Push(1);
            stack.Push(4);
            stack.Push(5);
            stack.Push(2);
            stack.Show();


            stack.Pop();
            stack.Show();

            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Count: {stack.Count()}");

            //int x = 5; int y = 10;
            //Console.WriteLine($"X: {x} - Y: {y}");

            //new Car().Test(ref x, ref y);
            //Console.WriteLine($"X: {x} - Y: {y}");

            //string str1 = "str1";
            //string str2 = "str2";
            //Console.WriteLine(str1 + str2);

            //new Car().Test(ref str1, ref str2);
            //Console.WriteLine(str1 + str2);

            //Box<string> box = new Box<string>("string");
            //Console.WriteLine(box.GetContent());

            //var box2 = new Box<List<string>>(new List<string>
            //{
            //    "string1",
            //    "string2"
            //});
            //Console.WriteLine(box2.GetContent()[1]);

            //var capitals = new Dictionary<string, string>();
            //capitals.Add("Ukraine", "Kyiv");
            //capitals.Add("France", "Paris");
            //Console.WriteLine(capitals["France"]);
        }
    }
}
