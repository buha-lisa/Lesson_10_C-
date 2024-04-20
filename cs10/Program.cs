namespace cs10
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-5): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        var max = new Task1_3().MaxValue<int>(3, 6, 7);
                        Console.WriteLine($"Max: {max}");
                        break;
                    case 2:
                        var min = new Task1_3().MinValue<int>(3, 6, 7);
                        Console.WriteLine($"Min: {min}");
                        break;
                    case 3:
                        int[] ints = { 4, 5, 6 };
                        var sum = new Task1_3().SumArray<int>(ints);
                        Console.WriteLine($"Sum: {sum}");
                        break;
                    case 4:
                        var stack = new Stack<int>(5);
                        stack.Push(1);
                        stack.Push(4);
                        stack.Push(5);
                        stack.Push(2);
                        stack.Push(7);
                        Console.WriteLine($"Peek: {stack.Peek()}");
                        while (stack.Count() > 0)
                        {
                            Console.WriteLine(stack.Pop());
                        }
                        break;
                    case 5:
                        var queue = new Queue<int>(5);
                        queue.Enqueue(1);
                        queue.Enqueue(4);
                        queue.Enqueue(5);
                        queue.Enqueue(2);
                        queue.Enqueue(7);
                        Console.WriteLine($"Peek: {queue.Peek()}");
                        while (queue.Count() > 0)
                        {
                            Console.WriteLine(queue.Dequeue());
                        }
                        break;
                }
                if (task == 0) break;
            }
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
