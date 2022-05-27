using System;
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        //Ref is a mechanism of getting information about types and objects
        static void Main(string[] args)
        {
            int x = 8;
            Type typeInt = typeof(string); //Type is class of Reflection     //Type typeInt = typeof(Console); 
            //Type typeInttt = typeof(badrjan);
            Console.WriteLine(typeInt.FullName);
            Console.WriteLine(typeInt.IsClass);
            Console.WriteLine(typeInt.IsEnum);

            FieldInfo[] fields = typeInt.GetFields();// int typeof
            foreach (var fild in fields)
            {
                object o = fild.GetValue("badrjan");
                Console.WriteLine(o.ToString());
            }

            //Get Object fields value 
            Calc calc = new Calc(7,89,"89");
            Type typeClass = calc.GetType();

            FieldInfo[] parameters = typeClass.GetFields(BindingFlags.NonPublic|BindingFlags.Public| BindingFlags.Instance);
            foreach (var item in parameters)
            {
                object r = item.GetValue(calc);
                Console.WriteLine(r.ToString());
            }
        }

        class Calc
        {
            public string Symbol;
            private int X;
            private int Y;           
        
            public Calc(int x,int y,string z)
            {
                Symbol = z;
                this.X = x;
                this.Y = y;
            }
        }
    }
    
}
