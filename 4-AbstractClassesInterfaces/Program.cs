using System;
namespace _4_AbstractClassesInterfaces
{
    abstract class Weapon
    {
        public int field;
        public abstract int MyProperty { get; set; }
        private int myVar;

        public int MyPropertyy
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public abstract void Fire();
        public  void Fires()
        { }
        public void Showinfo()
        {
            Console.WriteLine();
        }
        // public virtual void Met();
    }

    class Gun : Weapon
    {
        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Fire()
        {
            Console.WriteLine("GunBow");
        }
        
    }
    class LaserGun : Weapon
    {
        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Fire()
        {
            Console.WriteLine("LaserBow");
        }
    }
    
    //{
    //    public override void Fire()
    //    {
    //        Console.WriteLine("Bow");
    //    }
    //}
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
        public void CheckInfo(Weapon weapon)
        {
            Console.WriteLine("CheckInfo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Weapon gun = new Gun();          
            //Gun gg = new Gun();
            //Player player = new Player();
            //Weapon[] inventory = { gg, new LaserGun() };
            //foreach (var item in inventory)
            //{
            //    player.Fire(item);
            //}

            //A1 a2 = new A2();
            //A1[] arrayy = { a2,new A2(), new A3() };
            //foreach (var item in arrayy)
            //{
            //    Console.WriteLine(item.ToString());
            //}
        }
    }


    public class A1
    { 
        public int A1M(int t)
        {
            return t * t;
        }
    }

    public class A2
    {
        public int MyProperty { get; set; }
        private int myVar;

        public int E
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
    public class A3
    {
        public int MyProperty { get; set; }
        private int myVar;

        public int E
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }


}