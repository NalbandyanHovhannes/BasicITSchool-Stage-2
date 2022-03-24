using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DataStructures
{
    class Stack
    {
        public void StackMethod()
        {
            Stack<string> newStack = new Stack<string>();
            //Stack<string> stack1 = newStack <string>();
            string[] str = {
                "MCA",
                "BCA",
                "BBA",
                "MBA",
                "MTech"
            };
          ////  Stack<string> stack2 = newStack<string>(str);
            //Stack<string> stack3 = newStack<string>(10);
            Console.WriteLine("The elements in the stack1 are:" + str.Count());
            //Console.WriteLine("The elements in the stack2 are:" + stack2.Count());
           // Console.WriteLine("The elements in the stack3 are:" + stack3.Count());
        }
    }
}
