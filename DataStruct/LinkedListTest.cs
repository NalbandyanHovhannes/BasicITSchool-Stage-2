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
            testLinkedList.AddLast(0);
            testLinkedList.AddLast(1);
            testLinkedList.AddLast(2);
            testLinkedList.AddLast(3);
            testLinkedList.AddLast(4);

            foreach (int i in testLinkedList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
