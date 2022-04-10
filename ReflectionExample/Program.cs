using System;
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        //Ref is a mechanism of getting information about types and objects
        static void Main(string[] args)
        {
            Type typeInt = typeof(int); //Type is class of Reflection     //Type typeInt = typeof(Console); 
            Console.WriteLine(typeInt.FullName);

            FieldInfo[] fields = typeInt.GetFields();
            foreach (FieldInfo fild in fields)
            {
                object o = fild.GetValue(null);
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
