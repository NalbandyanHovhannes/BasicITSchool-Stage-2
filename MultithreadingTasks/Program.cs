using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingTasks
{
    class Program
    {
        private int x = 1;
        static void Main(string[] args)
        {
            //int i = 0;
            Method2();
            Method1();
            Console.WriteLine("ha inch anem");
        }

        //static async void Method2()
        //{
        //    int i = 100000;
        //    while (i != 100100)
        //    {
        //        i++;
        //        //await Thread.Sleep(500);
        //        Console.WriteLine(i);
        //    }

        //}
        static async void Method1()
        {
            await Task.Run(() =>
            {
                DoWork1();
            });
        }
        static async void Method2()
        {
            await Task.Run(() =>
            {
                DoWork2();
            });
        }
        public static void DoWork1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("DOWORK11111111111");
            }
        }

        public static void DoWork2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("DOWORK22222222222");
            }
        }
    }
}
