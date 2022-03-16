﻿using System;

namespace _3_Polymorphism
{
    public class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("_"); 
        }
    }
    class Cat : Animal
    {
        public int x;
        public override void Voice()
        {
            Console.WriteLine("Mrrr !!!");
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }

        public override string ToString()
        {
                  
            return "I'm a cat !!!";
        }
    }

    class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Haf !!!");
        }
    }
    class Anasun : Cat
    {
    }
        class Program
    {
        static void Main(string[] args)
        {
            // is
            // as
            Cat cat1 = new Cat();
            cat1.Voice();
            //MRRR
            //demq Alice , Mrr
            //MRR
            //int t =(int)8
            Animal animalCat = (Animal)cat1; //upcast
            Anasun anasun = new Anasun();
            Anasun pr = (Anasun)cat1;
            //animalCat = cat1;
            if (cat1 is Program)
            {
                Console.WriteLine("istrue");
            }
                animalCat.Voice();

            Cat cat2 = (Cat)cat1;    //downcast
            cat2.Voice();

            Animal animal1 = new Animal();
            Animal animal2 = new Animal();

            //Console.WriteLine("Enter the magnet that You Need");
            //string animalType = Console.ReadLine();
            //if (animal1 == animal2)
            //{

            //}


            //animal2 = animal1;
            //Console.WriteLine(animal2.GetHashCode());
            //Console.WriteLine(animal1.GetHashCode());

            //Cat cat = null;
            //cat = new Cat();

            //Cat my = (Cat)animalCat; //UpCast

            //switch (animalType)
            //{
            //    case "cat":

            //        if (cat is Animal)
            //        {

            //        }

            //        break;

            //    case "dog":
            //        var dog = new Dog();
            //        animal1 = dog;
            //        break;

            //    default:
            //        {
            //            Console.WriteLine("Error: Wrong magnet name");
            //            break;
            //        }
            //}

            //if (animal1 != null)
            //{
            //    animal1.Voice();
            //}
            //animal1.Voice();
            //Animal d = animal1 as Dog;//DownCast///UpCast
            //d.Voice();
            //int x = cat.x;
            //Console.ReadKey();


        }
    }
}
