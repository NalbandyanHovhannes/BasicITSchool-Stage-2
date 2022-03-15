using System;

namespace OOP_1_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass2 derivedClass2 = new DerivedClass2();
            


        }
    }
    public class BaseClass
    {
        public int bc1;
        public int BaseMethod(int t)
        {
            return t * t;
        }
        public BaseClass()
        {

        }
    }
    public class DerivedClass1 : BaseClass
    {
        public int testMethod(int i)
        {
            return BaseMethod(8);
        }

    }

    public class DerivedClass2:DerivedClass1
    {

        public int Method1(int t)
        {
            BaseMethod(9);//base method
            return t * t;
        }

    }
}
