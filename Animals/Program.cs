using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.voice = "";
            //dog.Voice2();
            dog.Voice1();
            dog.Met();
            Animal animal = new Animal();
            animal.Voice1();

        }
    }
    public class Animal
    {
        public string voice;
        public void Voice1()
        {
            Console.WriteLine("-_-");
        }
    }

    public class Dog : Animal
    {
        //Animal animal = new Animal();
        //anim
        public void Voice1()
        {
            Console.WriteLine("HafHaf");
        }

        public void Met()
        {
            Animal animal = new Animal();
            animal.Voice1();
        }



    }
    public class Cat:Dog
    {
        public void Voice()
        {
            Console.WriteLine("Myayy");
        }
    }
}
