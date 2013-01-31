using MVC.Interface;

namespace MVC.Code
{
    public class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;
        private static int _numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }
        public void Quack()
        {
            _duck.Quack();
            _numberOfQuacks++;
        }

        public static int Quacks
        {
            get { return _numberOfQuacks; }
        }

        public void RegisterObserver(IObserver observer)
        {
            _duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _duck.NotifyObservers();
        }
    }
}