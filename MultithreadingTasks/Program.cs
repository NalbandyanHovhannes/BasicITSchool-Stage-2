﻿using System;
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
            //Task task5 = new Task(() => Thread.Sleep(2000000000)); 

            //Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello Task222222222222!"));
            //Task task3 = Task.Run(() => Console.WriteLine("Hello Task!333333333333333"));
            //Task task4 = new Task(() => Console.WriteLine("Task1 is executed44444444444444444"));
            //task1.Start();


            Task task1 = new Task(() => Console.WriteLine("Hello Task111111111111!"));
            Task task2 = new Task(() => Console.WriteLine("Hello 2222222222222222222!"));
            Task task3 = new Task(() => Console.WriteLine("Hello 33333333333333!"));


            //Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));
            //Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));
            task1.Wait(100);   // wait end of task1
            task2.Wait(300);   // wait end of task2
            task3.Wait(900);   // wait end of task3
            task1.Start();
            task2.Start();
            task3.Start();
            Console.ReadKey();
            //task2.Start();
            //task3.Start();
            //task1.Wait(2000);
            //task1.RunSynchronously();
        }
        static async void Method1async()
        {
            Task.Run(() =>
           {
               DoWork1();
           });
            Console.ReadKey();
        }
        public static void DoWork1()
        {
            for (int t = 0; t < 10; t++)
            {
                Console.WriteLine("1");
            }
        }
        public static void DoWork2()
        {
            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine("2");
            }
        }
    }
}
