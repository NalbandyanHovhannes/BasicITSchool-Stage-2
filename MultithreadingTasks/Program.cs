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
            async void Method2()
            {
                int i = 100000;
                while (i != 100100)
                {
                    i++;
                    //await Thread.Sleep(500);
                    Console.WriteLine(i);
                }
               
            }
            async void Method1()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(i);

                    }
                });
            }
            Method2();
            Method1();
            Console.WriteLine("ha inch anem");
        }
    }
}
