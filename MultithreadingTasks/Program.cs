using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingTasks
{
    class Program
    {

        //Task task = new Task(() => Console.WriteLine("Hello Task!"));
        //task.Start();
        //Task task = Task.Factory.StartNew(() => Console.WriteLine("Hello Task!"));
        //Task task = Task.Run(() => Console.WriteLine("Hello Task!"));

        //Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
        //task1.Start();

        //Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));

        //Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));

        //task1.Wait();   // wait end of task1
        //task2.Wait();   // wait end of task2
        //task3.Wait();   // wait end of task3


        //task1.Start();  
        //task1.Wait();   

       // task1.RunSynchronously();  start sync


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
