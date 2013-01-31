using System;
using MVC.Interface;

namespace MVC.Code
{
    public class Quackologist : IObserver 
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("Quackologist: {0} just quacked.", duck);
        }
    }
}