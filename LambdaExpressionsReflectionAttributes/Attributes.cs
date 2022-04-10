using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsReflectionAttributes
{
    class Attributes:System.Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Attributes()
        {

        }
        public Attributes(int x ,int y)
        {
            X = x;
            Y = y;

        }
        public override string ToString()
        {
            return $"[{X};{Y}]";
        }
    }
}
