using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    interface ICalculation
    {
        public int weight { get; set; }
        public double value { get; set; }
        public int Calc();
        public int Calc2()
        {
            return 2;
        }


    }
}
