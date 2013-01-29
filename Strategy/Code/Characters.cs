namespace Strategy.Code
{
    public class Queen : Character
    {
        public Queen()
        {
            SetWeaponBehavior(new NoWeapon());
        }
    }

    public class King : Character
    {
        public King()
        {
            SetWeaponBehavior(new NoWeapon());
        }
    }

    public class Troll : Character
    {
        public Troll()
        {
            SetWeaponBehavior(new Axe());
        }
    }

    public class Knight : Character
    {
        public Knight()
        {
            SetWeaponBehavior(new Sword());
        }
    }
}