using System;

namespace _5_Generics
{
    public class Examples
    {

        public string  Adding<T>(T a)
        {
            //Console.WriteLine(a + b);
            var castAll = a.ToString();
            
            return castAll;
        }

       public   void Swap<T>(  T  lhs,  T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public  void TestSwap()
        {
            int a = 1;
            int b = 2;

            string a1 = "string 1";
            string b1 = "string 2";

            double a2 = 2.3;
            double b2 = 2.8;

            Swap<int>(  a,   b);
            Console.WriteLine(a + " " + b);

            Swap<string>( a1,  b1);
            Console.WriteLine(a + " " + b);

            Swap<double>( a2,  b2);
            Console.WriteLine(a + " " + b);
        }

    }
}
