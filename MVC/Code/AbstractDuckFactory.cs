using MVC.Interface;

namespace MVC.Code
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedheadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
    }
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }

    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}