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

            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");
        }
    }
}
