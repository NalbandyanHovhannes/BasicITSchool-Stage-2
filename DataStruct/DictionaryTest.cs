using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    internal class DictionaryTest
    {
        public static void PrintDictionary()
          {
        Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("key1", "value1");
            dic.Add("key9", "value5");
            dic.Add("key3", "value3");
            dic.Add("key4", "value3");

            foreach (string key in dic.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (string values in dic.Values)
            {
                Console.WriteLine(values);
            }

        }
    }
}
