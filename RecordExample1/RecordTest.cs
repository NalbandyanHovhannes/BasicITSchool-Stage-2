using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordExample1
{
    internal record RecordTest(int t)
    {
        public int MyProperty { get; set; }
        public int MyMeth(int t)
        { return t * t; }

    }
}
