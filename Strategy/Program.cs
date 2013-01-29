using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Code;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var queen = new Queen();
            var king = new King();
            var troll = new Troll();
            var knight = new Knight();

            queen.Attack();
            king.Attack();
            troll.Attack();
            knight.Attack();
            knight.SetWeaponBehavior(new BowAndArrow());
            knight.Attack();

            Console.ReadKey();
        }
    }
}
