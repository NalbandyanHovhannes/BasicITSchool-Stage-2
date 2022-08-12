namespace DataStruct
{
    internal class StackTest
    {
        public static void PrintStack()
        {
            Stack<int> stacktest = new Stack<int>();
            stacktest.Push(0);
            stacktest.Push(1);
            stacktest.Push(2);
            stacktest.Push(3);

            while (stacktest.Count > 0)
            {
                Console.WriteLine(stacktest.Pop());
            }

        }
    }
}
