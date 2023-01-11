using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    internal class HashSetTest
    {
        public static void PrintHashSet()
        {
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("11");
            hashset.Add("11");
            hashset.Add("3333");
            hashset.Add("44444");
           foreach (string s in hashset)
            {
                Console.WriteLine( s.IndexOf('A'));
                
            }
        }
    }
}
