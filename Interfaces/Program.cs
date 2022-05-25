using System;


namespace Interfaces
{
    class Program
    {
        //By default, members of an interface are abstract and public.
        //Interfaces can contain properties and methods, but not fields.


        //Notes on Interfaces:
        //Like abstract classes, interfaces cannot be used to create objects(in the example above, it is
        //not possible to create an "IAnimal" object in the Program class)

        //Interface methods do not have a body - the body is provided by the "implement" class
        //On implementation of an interface, you must override all of its methods
        //Interfaces can contain properties and methods, but not fields/variables
        //Interface members are by default abstract and public
        //An interface cannot contain a constructor(as it cannot be used to create objects)
        //Why And When To Use Interfaces?
        //1) To achieve security - hide certain details and only show the important details of an object (interface).

        //2) C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it
        //can be achieved with interfaces, because the class can implement multiple interfaces. Note: To implement
        //multiple interfaces, separate them with a comma (see example below).




        static void Main(string[] args)
        {
            //int i = 8;
            //string tt = i.ToString();
            BaseInitClass o = new BaseInitClass();
           // var t = o.prop1;
            o.Getcv();
            //o.Calc();


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

         void Calc2()
        {
            Console.WriteLine("");
        }
        private void Calc()
        {
            Console.WriteLine("");
        }
        class Testclass
        {
            public int o;
            public Testclass()
            {
                 int  To(int y)
                {
                    int x = 8;
                    return x;
                }

            }
        }

        void Getcv();

    }

    public class BaseInitClass : Iimplementation
    {
        public int prop1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //Iimplementation.Testclass;
        Iimplementation ia;
        public void Getcv()
        { 
            throw new NotImplementedException();
        }
       
    }
    public class DerivedClass : BaseInitClass
    {




    }

}