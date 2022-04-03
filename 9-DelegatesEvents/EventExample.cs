using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DelegatesEvents
{
   public class EventExample

    {
        public delegate int ValueDelegate(int i);
        public delegate  void MyDelegate();
        public event MyDelegate Event;

    }
}
