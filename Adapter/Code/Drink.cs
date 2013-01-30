using System;

namespace Adapter.Code
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCindiments();
        }

        public abstract void Brew();
        public abstract  void AddCindiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCindiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }

    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        public override void AddCindiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}