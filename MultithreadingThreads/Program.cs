using System;
using System.Diagnostics;
using System.Threading;

namespace MultithreadingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.IsAlive);
            Console.WriteLine(thread.Name);
            Console.WriteLine(thread.GetHashCode());
            Process.Start("https://www.facebook.com/");
        }
    }
}
