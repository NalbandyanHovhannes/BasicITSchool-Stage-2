using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Apple :  ICalculation
    {
        public int weight        {
            get;
            set;         }

        public double value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Calc()
        {
            throw new NotImplementedException();
        }
       
        
    }
}

