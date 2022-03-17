using System;


namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
             int i = 8;
            string tt = i.ToString();
            BaseInitClass o = new BaseInitClass();
            var t = o.prop1;
            o.Getcv();
            o.Calc();


        }
    }

    interface Iimplementation
    {
        //public int t;

        //Auto property
        public int prop1 { get; set; }

        //propert assign      
        public int MyProperty
        {
            get { return prop1 + 1; }
            set { prop1 = value; }
        }

        void Calc()
        {
            Console.WriteLine("");
        }
        class Testclass
        {
            public int o;
            public Testclass()
            {

            }
        }

        void Getcv();

    }

    public class BaseInitClass : Iimplementation
    {
        public int prop1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Getcv()
        {
            Console.WriteLine("");
        }
        public void Calc()
        {
            Console.WriteLine("ururur");
        }
    }
    public class DerivedClass : BaseInitClass
    {




    }

}