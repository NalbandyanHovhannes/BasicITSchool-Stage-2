using System;

namespace SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
    public class Class1
    { }
    public class Class2
    { }
    public class Class3
    { }
    public sealed class SealedClass:Class1 { }

}
