using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Abstract2: Abstract1
    {
        
        public abstract string NameAbstract2 { get; set; }

        public void ImpMethod() { }
        public virtual void ImpMethodVirtual2() { }
        public abstract void ImpMethodAbstract22();

    }

}
