using System;
using MVC.Interface;

namespace MVC.Code
{
    public class MallardDuck : IQuackable
    {
        private readonly Observable _observable;
        public MallardDuck()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }

    public class RedheadDuck : IQuackable
    {
        private readonly Observable _observable;
        public RedheadDuck()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }

    public class DuckCall : IQuackable
    {
        private readonly Observable _observable;
        public DuckCall()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }

    public class RubberDuck : IQuackable
    {
        private readonly Observable _observable;
        public RubberDuck()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}