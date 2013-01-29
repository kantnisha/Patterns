using System;

namespace Strategy.Code
{
    public class Knife : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Knife");
        }
    }

    public class BowAndArrow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Bow");
        }
    }

    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Axe");
        }
    }

    public class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Sword");
        }
    }

    public class NoWeapon : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("No weapon!!!");
        }
    }

}