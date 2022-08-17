using System;

namespace _9_DelegatesEvents
{
    public class EventExample

    {
        public delegate int ValueDelegate(int i);
        public event EventHandler Doit;
        public delegate  void MyDelegate();
        public event MyDelegate Event;

    }
}
