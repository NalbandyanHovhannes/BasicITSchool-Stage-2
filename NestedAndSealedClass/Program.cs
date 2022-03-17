using System;

namespace NestedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class ParentClass
    {
        public int t;
        public int MyProperty { get; set; }
        public void Method1()
        { Console.WriteLine("Method1"); }

        public class NestedClass: Class2
        {
            public void Method2()
            { Console.WriteLine("Method1"); }

        }   
       
    }
    public class Class2:ParentClass
    {

    }
}
