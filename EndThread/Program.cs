

Thread thread1 = new Thread(Dowork1);
thread1.Start();
Thread thread2 = new Thread(new ParameterizedThreadStart(Dowork2));
thread2.Start(int.MaxValue);


int j = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    j++;
    if (j % 10000 == 0)
    {
        Console.WriteLine("Mainnnnnnnnnnnnnnnnnnnn");
    }
}
Console.ReadLine();



void Dowork1()
{
    int j = 0;
    for (int i = 0; i < int.MaxValue; i++)
    {
        j++;
        if (j % 10000 == 0)
        {
            Console.WriteLine("Dowork1");
        }
    }
}
void Dowork2(object max)
{
    int j = 0;
    for (int i = 0; i < (int)max; i++)
    {
        j++;
        if (j % 10000 == 0)
        {
            Console.WriteLine("Dowork2222222");
        }
    }
}