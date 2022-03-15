using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PublicClass class1 = new PublicClass();

            //var a = class1.a;
            var b = class1.b;
            //var c = class1.c;
            //var d = class1.d;
            //var e = class1.e;
            var f = class1.f;
            var g = class1.g;

            //------------------------------
            DerivedClass derivedClass = new DerivedClass(b);
            
        }
    }
    public class PublicClass
    {
        int a = 1;
        public int b = 2;
        private int c = 3;
        protected int d = 4;
        private protected int e = 5;
        internal int f = 6;
        protected internal int g = 7;
        public void Method1(int t) { }
        public PublicClass()
        {
            this.Method1(b);
        }
    }

    public class DerivedClass:PublicClass
    {
        public int x;
        public void Method2(int t) { }


        public DerivedClass(int x) 
        {
            this.Method2(x);
        }


    }
}
