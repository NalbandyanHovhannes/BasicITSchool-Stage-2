using System;

namespace LambdaExpressionsReflectionAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            static double Method(float n)
            {
                return n * n;
            }

            //Calculate calculate= new Calculate(Method);

            //Calculate calculate0 = Method; // Method explicit 

            // Lambada
            //Calculate calculate1 = delegate (float n) { return n * n; };            // Method
            //Calculate calculate2 = (n) => { Console.WriteLine(); return n * n; };   // Operator
            //Calculate calculate3 = (n) => n * n;                                    // Expression

           // Print p = () => Console.WriteLine();
            //calculate1=calculate1=calculate1 



            //Attribute
            var photo = new Photo("Screenshot_2.png")
            {
                Path = @":\Users\HP\Desktop"
            };

            var type = typeof(Photo);
            var attribut = type.GetCustomAttributes(false);
            foreach (var Attr in attribut)
            {
                Console.WriteLine(Attr);
            }
            var properties = type.GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine(item.PropertyType + "  " + item.Name);



                Console.ReadKey();
            }
        }
    }
}
