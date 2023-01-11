namespace DataStruct
{
    internal class QueueTest
    {
        public static  void PrintQueue()

        {
            Queue<string> queuetest = new Queue<string>();
            queuetest.Enqueue("651");
            queuetest.Enqueue("651");
            queuetest.Enqueue("651");
            queuetest.Enqueue("651");

            for (int i = 0; i < queuetest.Count; i++)
            {
                Console.WriteLine(queuetest.Dequeue());
            }
        }
    }
}
