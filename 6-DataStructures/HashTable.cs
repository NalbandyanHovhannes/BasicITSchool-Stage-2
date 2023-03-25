using System;
using System.Collections;
using System.Collections.Generic;

namespace _6_DataStructures
{
    class HashTable
    {
        public void HashMethod()
        {
            Dictionary<string, float> AuthorList = new Dictionary<string, float>();

            Hashtable HT = new Hashtable();
            HT.Add(1, "s");
            HT.Add(89,null);
            HT.Add(3, "n");
            HT.Add(300,13.5m);
            HT.Add(8, "n");
            HT.Add(2, "a");
            HT.Add(5, "u");
            HT.Add("asjhkdajhd", "u");
            foreach (object i in HT.Keys)
                Console.WriteLine(i);
            foreach (object J in HT.Values)
                Console.WriteLine(J);
            foreach (DictionaryEntry di in HT)
                Console.WriteLine("keys={0} values={1}", di.Key, di.Value);
            Console.ReadKey();
        }
    }
}
