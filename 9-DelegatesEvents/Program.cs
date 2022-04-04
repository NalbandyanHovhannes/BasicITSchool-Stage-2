using System;

namespace _9_DelegatesEvents
{
    public delegate void ClassDelegate(); //global dele
    class Program
    {
        //Delegate
        private delegate int ValuesDelegate(int i);

        public delegate void Actionnnnnnn();
        //Action
        public delegate void  Action();
        //Action action = Method1;//return ?  16 argument

        //Predicate
        public delegate bool Predicate<T>(T value);//return bool only one argument

        //Func
        public delegate int Func(string t, int yy);


        static void Main(string[] args)
        {
            ////ClassBadrjan  classBadrjan=new ClassBadrjan()
            ////public delegate void ClassDelegate(); //global dele
            //ClassDelegate classDelegate ;
            //classDelegate = null;
            ////classDelegate.Invoke();
            //classDelegate?.Invoke();
            


            //ClassDelegate classDelegate1 = new ClassDelegate(Method4);
            //classDelegate1 += Method4;
            ////classDelegate1 -= Method4;
            //classDelegate1.Invoke();

            //Console.WriteLine("del1+del2");
            //ClassDelegate classDelegate2 = classDelegate + classDelegate1;
            //classDelegate2.Invoke();

            ////--------Value
            //var valueDelegate = new ValuesDelegate(MethodValues);
            //valueDelegate += MethodValues;
            //valueDelegate += MethodValues;
            //valueDelegate((new Random()).Next(10, 50));

            //Action action = Method1;//return ?  16 argument
            //Console.ReadLine();

            //Func<string, int> ffunc = Methodffunc;
            //ffunc?.Invoke("");

            //-----------------eVENT 

            Person person = new Person();
            person.Eating += Person_Eating;
            person.EatMorning(DateTime.Parse("04.04.2022 00:50:00"));
            person.EatMorning(DateTime.Parse("04.05.2022 00:50:00"));


        }
        public static void Person_Eating()
        { Console.WriteLine("EatAll"); }

        public static int Methodffunc(string o)
        { return 9; }
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
        public void Met(int a, int hjtyj, int fghfdh, int fghfha, int afghfgh, int fghfa, int fgertfa, int fjkuja, int afghfg, int sdfgfadfa, int sdfaa, int fbfsgga, int asadgfas, int sfgva, int asdfsdg, int asdgasg, int dfasddfasa, int adafgdafgsf, int asdfsad, int sdfsaa, int a5, int abh, int ah, int ads, int asd, int aerg, int aerrg, int agerg, int aerdfgdfg, int adfg, int agfdfgd, int adfgdfb, int adfgd) 
        { }
    }
}

//The Func delegate takes zero, one or more input parameters, and returns a value
//(with its out parameter).

//Action takes zero, one or more input parameters, but does not return anything.

//Predicate is a special kind of Func. It represents a method that contains a
//set of criteria mostly defined inside an if condition and checks whether the
//passed parameter meets those criteria or not.

