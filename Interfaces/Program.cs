using System;


namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
            get { return prop1+1; }
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

    public class InitClass : Iimplementation
    {
        public int prop1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Getcv()
        {
            throw new NotImplementedException();
        }
    }
}
