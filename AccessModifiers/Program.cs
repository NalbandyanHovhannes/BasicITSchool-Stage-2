using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PublicClass class1 = new PublicClass();

            //var a = class1.a;//default value
            var b = class1.b;//public
            //var c = class1.c;private
            //var d = class1.d;//protected
            //var e = class1.e; private protected
            var f = class1.f;//internal
            var g = class1.g;//protected internal

            //------------------------------
            //DerivedClass derivedClass = new DerivedClass(b);
            DerivedClass2 derivedClass2 = new DerivedClass2();
            //PublicClass PublicClass4 = new PublicClass();
        }
    }
    public class PublicClass
    {
        int a = 1;
        public int b = 2;
        private int c = 3;
        protected int d = 7;
        private protected int e = 4;
        internal int f = 6;
        protected internal int g = 7;
        private void Method1(int t)

        { Console.WriteLine("kill him"); }
        public void Method4()
        { Method1(9); }
        public PublicClass()
        {
            Method1(8);
        }
    }

    public class DerivedClass : PublicClass
    {
        public int x;
        public void Method2(int t) { }

        protected void Method3(int t) { Console.WriteLine(8); }

        public DerivedClass()
        {

        }
        public DerivedClass(int x)
        {
            this.Method2(x);
        }


    }

    public class DerivedClass2 : DerivedClass
    {

        public void DerClas2Met1(int t)
        {
            Console.WriteLine("Degusto");
        }
        public void Test()
        {
            Method3(8);



        }

    }
}
