using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsReflectionAttributes
{

    public class Lambda
    {
        public double Test1(float n)
        {
            return n * n;
        }

        double Test3(float n) => n * n;


        //public static double Method1(float n) => n* n;

        private List<int> array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void Method()
        {
            //var doubleList = array.Select((x) => { return x * 2; });
            //var doubleList = array.Select(x => { return x * 2; });
            //var doubleList = array.Select((x) => { x++; return x * 2; });
            var doubleList = array.Select(x => x * x);
            var odds = array.Where(x => x % 2 == 1);
            var nine = array.First(x => x == 9);
            var count = array.Count(x => x > 5);
        }
    }
}
