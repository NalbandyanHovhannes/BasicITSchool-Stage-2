using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DataStructures
{
    class List
    {
        public void ListMethod()
        {
            List<int> numberList = new List<int>();
            numberList.Add(32);
            numberList.Add(21);
            numberList.Add(45);
            numberList.Add(11);
            numberList.Add(89);
            // List of string
            List<string> authors = new List<string>(5);
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");

            // Remove an item
            authors.Remove("New Author1");

            // Remove 3rd item
            authors.RemoveAt(3);

            // Remove a range
            authors.RemoveRange(3, 2);

            // Remove all items
            authors.Clear();

            Console.WriteLine(authors.IndexOf("Naveen Sharma", 2));

            //reverse
            authors.Reverse();



            // Program: Copy items from one list to another list
            Console.WriteLine("Import one list to another!");

            // Create List1
            List<string> listOne = new();
            listOne.Add("One");
            listOne.Add("Two");
            listOne.Add("Three");
            listOne.Add("Four");
            listOne.Add("Five");

            // Create List2
            List<string> listTwo = new();
            listTwo.Add("A");
            listTwo.Add("B");
            listTwo.Add("C");

            // Add List2 to List1
            listOne.AddRange(listTwo);

            // Display
            foreach (string item in listOne)
                Console.WriteLine(item);

            Console.ReadKey();

        }
    }
}
