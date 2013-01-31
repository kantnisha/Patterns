using System.Collections.Generic;
using MVC.Interface;

namespace MVC.Code
{
    public class Flock  : IQuackable
    {
        private readonly List<IQuackable> _quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }
        public void Quack()
        {
            foreach (var quacker in _quackers)
            {
                quacker.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var quackable in _quackers)
            {
                quackable.RegisterObserver(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var quackable in _quackers)
            {
                quackable.NotifyObservers();
            }
        }
    }
}