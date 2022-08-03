using System;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

namespace IntroductionOOP
{
    [MemoryDiagnoser]
    class Program
    {
        static void Main(string[] args)
        {
            //OOP Key concepts
            //Incapsulation
            //Inheritance
            //Polymorphism
            //Abstraction //interface

            //Class modifire
            //public Public class is visible in the current and referencing assembly.
            //private Visible inside current class.
            //protected Visible inside current and derived class.
            //Internal Visible inside containing assembly.
            //Internal protected Visible inside containing assembly and descendent of thecurrent class.

            //Modifier Description
            //sealed Class can't be inherited by a derived class.
            //static Class contains only static members.
            //unsafe The class that has some unsafe construct likes pointers.
            //Abstract The instance of the class is not created if the Class is abstract.

            // Modifiers Outside Assembly Derived Class
            //outside assembly derived class
            //private No No
            //public Yes Yes
            //protected No No
            //internal Yes(this assembly only)   Yes(this assembly only)
            //internal protected Yes(this assembly only)   Yes

            IncapsulationClass1 obj1 = new IncapsulationClass1();
            obj1.t1 = 8;
            obj1.Test1(8);         

            IncapsulationClass2 obj2 = new IncapsulationClass2();
            obj2.pubt = 2;
            obj2.t = 22;
            IncapsulationClass3 obj3 = new IncapsulationClass3();
            obj3.pubt = 3;
            IncapsulationClass4 obj4 = new IncapsulationClass4();
            obj4.pubt = 4;
            IncapsulationClass5 obj5 = new IncapsulationClass5();
            obj5.pubt = 55;
            obj5.t = 5;
            IncapsulationClass6 obj6 = new IncapsulationClass6();
            obj6.pubt = 66;
            obj6.t = 6;

        }

        public class IncapsulationClass1
        {
            public int t1 = 1;
            protected int t2 = 1;
            private int t3 = 4; 
            public int Test1(int t)
            {
                string str = "852";
                int w = int.Parse(str);
                object b = t3;
                return (int)b;
            }
            private int Test2(int a)
            {
                string str = "852";
                int w = int.Parse(str);
                object b = a;
                return (int)b;
            }
       
        }
        public class IncapsulationClass2
        {
            public int t = 1;
            public int pubt = 1;
        }
        public class IncapsulationClass3
        {
            protected int t = 1;
            public int pubt = 1;
        }
        public class IncapsulationClass4
        {
            protected int t = 1;
            public int pubt = 1;
        }
        public class IncapsulationClass5
        {
            internal int t = 1;
            public int pubt = 1;
        }
        public class IncapsulationClass6
        {
            protected internal int t = 1;
            public int pubt = 1;
        }

        //ADD class diagram 
        //ctor dad,fath son
        //base ctor
    }
}
