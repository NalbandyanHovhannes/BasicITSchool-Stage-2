using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    internal class LinkedListTest
    {
        public static void PrintLinkedList()
        {

            LinkedList<int> testLinkedList = new LinkedList<int>();
            testLinkedList.AddLast(10);
            testLinkedList.AddLast(10);
            testLinkedList.AddLast(20);
            testLinkedList.AddLast(333);
            testLinkedList.AddLast(4444);
            var yt = testLinkedList.Find(20);
            var u = yt.ValueRef;


            foreach (int i in testLinkedList)
            {
                Console.WriteLine(testLinkedList.ElementAt(2));
            }
        }
    }
}
