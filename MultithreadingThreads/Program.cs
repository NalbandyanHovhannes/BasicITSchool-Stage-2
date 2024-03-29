﻿using System;
using System.IO;
using System.Text;
using System.Threading;

namespace MultithreadingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Task1);
            thread1.Start();   

            Thread thread2 = new Thread(Task2);
            thread2.Start();

            for (int i = 0; i < 10; i++)
            {
                int j = 1;
                j++;
                if (j % 2 == 0)
                {

                    Console.WriteLine("Maiiiinnnnnnnnnnnn");
                }
            }

            Console.ReadKey();            
        }


        static void Task1()
        {
            for (int i = 0; i <10; i++)
            {
                int j = 1;
                j++;
                if (j % 2 == 0)
                {
                    Console.WriteLine("Task1111111111111111111");
                }
            }
        }

        static void Task2()
        {
            for (int i = 0; i < 10; i++)
            {
                int j = 1;
                j++;
                if (j % 2 == 0)
                {

                    Console.WriteLine("Task22");
                }
            }
        }

        //ReadWriteWithThreads readWrite = new
        //    ReadWriteWithThreads("File1.txt", "File2.txt", "File3.txt", "File1Context", "File2Context", "File3Context");
        //readWrite.Threads();
        //Thread.Sleep(2000);
        //Thread thread = Thread.CurrentThread;
        //Console.WriteLine(thread.IsAlive);
        //Console.WriteLine(thread.Name);
        //Console.WriteLine(thread.GetHashCode());
        //Process.Start("https://www.facebook.com/");
    }
    class ReadWriteWithThreads
    {
        FileStream file1;
        FileStream file2;
        FileStream file3;

        string path1, path2, path3;


        public ReadWriteWithThreads(string path1, string path2, string context1, string context2)
        {
            this.path1 = path1;
            this.path2 = path2;

            using (file1 = new FileStream(path1, FileMode.OpenOrCreate))
            using (file2 = new FileStream(path2, FileMode.OpenOrCreate))
            {
                var buffer1 = GetBytes(context1);
                var buffer2 = GetBytes(context2);
                file1.Write(buffer1, 0, buffer1.Length);
                file2.Write(buffer2, 0, buffer2.Length);
            }
        }

        public ReadWriteWithThreads(string path1, string path2, string path3, string context1, string context2, string context3) : this(path1, path2, context1, context2)
        {
            this.path3 = path3;

            using (file3 = new FileStream(path3, FileMode.OpenOrCreate))
            {
                var buffer3 = GetBytes(context3);
                //File.WriteAllText(path3, context3);
                file3.Write(buffer3, 0, buffer3.Length);

            }
        }

        private void ReadFiles(object path)
        {
            try
            {
                lock (new object())
                {
                    StreamReader reader = new StreamReader((string)path);
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

                    //Thread.CurrentThread.Join();
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    WriteFile(reader.ReadToEnd());
                }

            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        private void WriteFile(string context)
        {
            System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            File.AppendAllText(path3, context);
            //Thread.CurrentThread.Join();
            System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        public void Threads()
        {
            Thread thread1 = new Thread(ReadFiles);
            thread1.Start(path1);

            Thread thread2 = new Thread(ReadFiles);
            thread2.Start(path2);
            Thread.Sleep(1000);
        }

        public byte[] GetBytes(string context)
        {
            return Encoding.UTF8.GetBytes(context);
        }
    }




}
