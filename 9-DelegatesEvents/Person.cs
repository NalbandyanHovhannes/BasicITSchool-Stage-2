using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DelegatesEvents
{
   public class Person
    {

        public delegate int ValueDelegate(int i);
        public delegate void MyDelegate();
        public event MyDelegate Event;
        public event Action Eating;
        public event EventHandler Doit;

        public void EatMorning(DateTime time)
        {

            if (time.Hour > 3)
            {
                Eating?.Invoke();
            }
            else {
                var args = new EventArgs();
                Doit?.Invoke(this,args); }

        }
    }
}
