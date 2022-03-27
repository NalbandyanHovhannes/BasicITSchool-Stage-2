using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Exceptions
{
    class Testing1
    {
        public void Method1()
        {
            try
            {
                int t = 0;
                int k = 8;

                Console.WriteLine(k/t);

            }
            catch (Exception)
            {
                throw new Exception ("cant devide 0");
            }
            finally { }
           // TryCatchFinnally tr = new TryCatchFinnally();
        }
        

        public  int RecursiveMethod()
        {
            return RecursiveMethod();
        }
    }
}
