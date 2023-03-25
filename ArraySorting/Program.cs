using System.Collections.Generic;

namespace ArraySorting
{
    internal class Program
    {
        static public int Meth(int[] ints,int x)
        {
            int lInts = ints.Length / 2;
            int temp = lInts;
            int MaxNum = 0;
            int count = 0;
            if (x > lInts)
            {
                MaxNum = lInts;
                temp /= 2;
                lInts += temp;
                count++;
            }
            else if (x < lInts)
            {
                temp = lInts - MaxNum;
                temp /= 2;
                lInts -= temp;
                count++;
            }
            else if (x == lInts)
                Console.WriteLine($"The count {count}");
            return 0;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] ints = new int[101];
            int x = 24;
            int lInts = ints.Length / 2;
            int temp = lInts;
            int MaxNum = 0;
            int count = 0;
            for (int i = 1; i < ints.Length; i++)
            {
                ints[i] = i;
            }
            for (int i = 0; i < 7; i++)
            {
                if (x > lInts)
                {
                    MaxNum = lInts;
                    temp /= 2;
                    lInts += temp + 1;
                    count++;
                    Console.WriteLine(lInts);
                }
                else if (x < lInts)
                {
                    temp = lInts - MaxNum;
                    temp /= 2;
                    lInts -= temp - 1;
                    count++;
                    Console.WriteLine(lInts);
                }
                else if (x == lInts)
                {
                    Console.WriteLine($"The count {count}");
                    break;
                }
            }
        }
    }
}