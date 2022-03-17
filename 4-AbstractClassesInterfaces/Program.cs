using System;
namespace _4_AbstractClassesInterfaces
{
    abstract class Weapon
    {
        public int field;
        public int MyProperty { get; set; }
        public abstract void Fire();
        public void Showinfo()
        {
            Console.WriteLine(GetType());
        }
    }
    class Gun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("GunBow");
        }
    }
    class LaserGun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("LaserBow");
        }
    }
    class Bow : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Bow");
        }
    }
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
        public void CheckInfo(Weapon weapon)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] inventory = { new Gun(), new LaserGun(), new Bow() };
            foreach (var item in inventory)
            {
                player.Fire(item);
            }
        }
    }
}