using System;

namespace IntroductionOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP
            //Incapsulation
            //Inheritance
            //Polymorphism
            //Abstraction


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


            //            Modifiers Outside Assembly Derived Class
            //outside assembly derived class
            //private No No
            //public Yes Yes
            //protected No No
            //internal Yes(this assembly only)   Yes(this assembly only)
            //internal protected Yes(this assembly only)   Yes

            //    ~customer()
            //    {
            //        Dispose();
            //    }


            IncapsulationClass1 obj1 = new IncapsulationClass1();
            //obj1.pubt = 8;
            //obj1.t = 88;
            IncapsulationClass2 obj2 = new IncapsulationClass2();
            //obj2.pubt = 2;
            //obj2.t = 22;
            IncapsulationClass3 obj3 = new IncapsulationClass3();
            //obj3.pubt = 3;
            //obj3.t = 33;
            IncapsulationClass4 obj4 = new IncapsulationClass4();
            //obj4.pubt = 4;
            //obj3.t = 44;
            IncapsulationClass5 obj5 = new IncapsulationClass5();
            //obj5.pubt = 55;
            //obj5.t = 5;
            IncapsulationClass6 obj6 = new IncapsulationClass6();
            //obj6.pubt = 66;
            //obj6.t = 6;

        }

        public class IncapsulationClass1
        {
            int t = 1;
            public int pubt = 1;

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
    }
}
