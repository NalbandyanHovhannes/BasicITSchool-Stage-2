using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingTasks
{
    public  class Program
    {
        static  void Main(string[] args)
           
        {
            //Method1();
            Method2();
            //Console.WriteLine("3");
            Console.ReadKey();            
        }

        static void Method2()
        {
            Task task1 = new Task(() => Console.WriteLine("Hello Task111111111111!"));
            Task task5 = new Task(() => Thread.Sleep(2000000000)); 

            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello Task222222222222!"));
            Task task3 = Task.Run(() => Console.WriteLine("Hello Task!333333333333333"));
            Task task4 = new Task(() => Console.WriteLine("Task1 is executed44444444444444444"));
            task1.Start();
            task2.Start();
            task3.Start();
            task5.Start();

            //Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));
            //Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));
            //task1.Wait();   // wait end of task1
            //task2.Wait();   // wait end of task2
            //task3.Wait();   // wait end of task3
            //task1.Start();
            //task1.Wait();
            //task1.RunSynchronously();
        }
        //static async void Method1async()
        //{
        //     Task.Run(() =>
        //    {
        //        DoWork1();
        //    });
        //    Console.ReadKey();  
        //}       
        public static void DoWork1()
        {
            for (int t = 0; t < 1000; t++)
            {
                Console.WriteLine("1");
            }
        }
        public static void DoWork2()
        {
            for (int y = 0; y < 1000; y++)
            {
                Console.WriteLine("2");
            }
        }
    }
}
