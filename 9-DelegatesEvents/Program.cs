using System;

namespace _9_DelegatesEvents
{
    public delegate void ClassDelegate(); //global dele
    class Program
    {
        //Delegate
        public delegate int ValuesDelegate(int i);


        //Action
        public delegate void Action();
        //Action action = Method1;//return ?  16 argument

        //Predicate
        public delegate bool Predicate<T>(T value);//return bool only one argument

        //Func
        public delegate int Func(string t);


        static void Main(string[] args)
        {
           
            ClassDelegate classDelegate = Method1;
            classDelegate += Method4;
            classDelegate();

            ClassDelegate classDelegate1 = new ClassDelegate(Method4);
            classDelegate1 += Method4;
            //classDelegate1 -= Method4;
            classDelegate1.Invoke();

            Console.WriteLine("del1+del2");
            ClassDelegate classDelegate2 = classDelegate+ classDelegate1;
            classDelegate2.Invoke();

            //--------Value
            var valueDelegate = new ValuesDelegate(MethodValues);
            valueDelegate += MethodValues;
            valueDelegate += MethodValues;
            valueDelegate((new Random()).Next(10, 50));

            Action action = Method1;//return ?  16 argument
            Console.ReadLine();

        }
        public static int MethodValues(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        public static void Method1()
        {
            Console.WriteLine("Method1");

        }
        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }
        public static void Method3(int t)
        {
            Console.WriteLine("Method3");
        }
        public static void Method4()
        {
            Console.WriteLine("Method4");
        }
    }
}
