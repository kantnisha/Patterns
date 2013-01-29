namespace Decorator.Code
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = " Espresso";
        }
        public override double Cost()
        {
            return 1.49 + Size * 0.50;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return 0.49 + Size * 0.50;
        }
    }
}