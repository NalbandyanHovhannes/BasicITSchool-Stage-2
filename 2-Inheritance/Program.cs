using System;

namespace _2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            BMW bMW = new BMW();
            bMW.CalcTax(8, 958);
        }
    }
}
