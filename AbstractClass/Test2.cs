using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Test2 : Abstract2
    {
        public override string NameAbstract2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void ImpMethodAbstract22()
        {
            throw new NotImplementedException();
        }

        public override void TestMethodAbstract1()
        {
            throw new NotImplementedException();
        }
        public override void ImpMethodVirtual2()
        {
            throw new NotImplementedException();
        }
    }
}
