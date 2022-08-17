using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    public delegate int DelegateWork(out int a);
    internal class HumanWork
    {
        public int BreakTime(out int a)
        {
            a = 8;
            Console.WriteLine(a-=1);
            return a;
        }
        public int SmokingTime(out int a)
        {
            a = BreakTime(out a);
            Console.WriteLine(a-=2 );
            return a;
        }
        public int CoffeeTime(out int a)
        {
            a = SmokingTime(out a);
            Console.WriteLine(a -= 3);
            return a;
        }
    }
}
