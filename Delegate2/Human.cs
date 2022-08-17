using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    public delegate void Action1();
    public class Human
    {
        public void WakeUp()
        {
            Console.WriteLine("wake up");
        }
        public void Tooth()
        {
            Console.WriteLine("tooth");
        }
        public void Washing()
        {
            Console.WriteLine("washing");
        }
        public void Smoking()
        {
            Console.WriteLine("smoking");
        }

    }
}
