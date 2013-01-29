namespace Decorator.Code
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            Size = _beverage.GetSize();
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            _beverage.SetSize(Size);
            return 0.10 + Size * 0.10 + _beverage.Cost();
        }
    }
}