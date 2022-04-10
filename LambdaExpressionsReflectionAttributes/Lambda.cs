using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsReflectionAttributes
{
    public delegate double Calculate(float num);
    public delegate void Print();
    public class Lambda
    {
        string test() { return "test"; }
        string test2() => "test2";
        //------------------------------------
        /// <summary>
        /// explicit static method
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns></returns>
        public static double Method(float n)
        {
            return n * n;
        }

        //public static double Method1(float n) => n* n;

    }
}
