using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DataStructures
{
    class HashTable
    {
        public void HashMethod()
        {
            Hashtable HT = new Hashtable();
            HT.Add(1, "s");
            HT.Add(3, "n");
            HT.Add(4, "j");
            HT.Add(2, "a");
            HT.Add(5, "u");
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
