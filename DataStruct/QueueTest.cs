namespace DataStruct
{
    internal class QueueTest
    {
        public static  void PrintQueue()

        {
            Queue<int> queuetest = new Queue<int>();
            queuetest.Enqueue(1);
            queuetest.Enqueue(2);
            queuetest.Enqueue(3);
            queuetest.Enqueue(4);

            for (int i = 0; i < queuetest.Count; i++)
            {
                Console.WriteLine(queuetest.Dequeue());
            }
        }
    }
}
