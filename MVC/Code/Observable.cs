using System.Collections.Generic;
using MVC.Interface;

namespace MVC.Code
{
    public class Observable : IQuackObservable 
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_duck);
            }
        }
    }
}