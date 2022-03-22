using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Generics
{
    class Examples
    {

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public static void TestSwap()
        {
            int a = 1;
            int b = 2;

            Swap<int>(ref a, ref b);
            Console.WriteLine(a + " " + b);
        }

    }
}
