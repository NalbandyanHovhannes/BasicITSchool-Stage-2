using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsReflectionAttributes
{
    [Attributes(15,25)]
    class Photo
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public Photo(string name)
        {
            Name = name;
        }
    }
}
