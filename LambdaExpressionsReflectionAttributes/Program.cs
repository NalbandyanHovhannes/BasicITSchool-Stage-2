using System;

namespace LambdaExpressionsReflectionAttributes
{
    class Program
    {
        static void Main(string[] args)
        {

            var photo = new Photo("Screenshot_2.png")
            { Path = @":\Users\HP\Desktop" };

            var type = typeof(Photo);
            var attribut = type.GetCustomAttributes(false);
            foreach (var Attr in attribut)
            {
                Console.WriteLine(Attr);
            }
            var properties = type.GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine(item.PropertyType+"  "+item.Name);
            }
                
                
                Console.ReadKey();
        }
    }
}
