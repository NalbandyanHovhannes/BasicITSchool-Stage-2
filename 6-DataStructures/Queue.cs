using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_DataStructures
{
    class Queue
    {
        public void QueueMethod()
        {
            Queue<string> newQueue = newQueue<string>();

           // string[] courses = { "MCA", "MBA", "BCA", "BBA", "BTech", "MTech" };
            //Queue<string> queue = newQueue<string>(courses);
            //Queue<string> queue = newQueue<string>(4);

            string[] courses = {
                "MCA",
                "MBA",
                "BCA",
                "BBA",
                "BTech",
                "MTech"
            };
            Queue<string> queue1 = newQueue<string>();
            //Queue<string> queue2 = newQueue<string>(courses);
           // Queue<string> queue3 = newQueue<string>(4);
            Console.WriteLine("Number of elements in queue1:" + queue1.Count());
           // Console.WriteLine("Number of elements in queue2:" + queue2.Count());
            //Console.WriteLine("Number of elements in queue3:" + queue3.Count());
        }

        public void Method2()
        {
            Queue<string> queue1 = newQueue<string>();
            queue1.Enqueue("MCA");
            queue1.Enqueue("MBA");
            queue1.Enqueue("BCA");
            queue1.Enqueue("BBA");
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }
        }

        private Queue<T> newQueue<T>()
        {
            throw new NotImplementedException();
        }
    }
}
