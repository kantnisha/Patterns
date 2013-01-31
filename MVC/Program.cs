using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVC.Code;
using MVC.Interface;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            var duckFactory = new CountingDuckFactory();
            Simulate(duckFactory);

            Console.ReadKey();
        }

        private static void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());


            var flockOfDucks = new Flock();
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            var flockMallardDuck = new Flock();

            var mallarOne = duckFactory.CreateMallardDuck();
            var mallarTwo = duckFactory.CreateMallardDuck();
            var mallarThree = duckFactory.CreateMallardDuck();
            var mallarFour = duckFactory.CreateMallardDuck();

            flockMallardDuck.Add(mallarOne);
            flockMallardDuck.Add(mallarTwo);
            flockMallardDuck.Add(mallarThree);
            flockMallardDuck.Add(mallarFour);

            flockOfDucks.Add(flockMallardDuck);

           // Console.WriteLine("Duck Simulator: Whole Flock Simulator");
           // Simulate(flockOfDucks);

          //  Console.WriteLine("Duck Simulator: Mallard Flock Simulator");
         //   Simulate(flockMallardDuck);

          
            Console.WriteLine("Duck Simulator: With Observer");
            var quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);

            Simulate(flockOfDucks);

            Console.WriteLine("Thr ducks quacked {0} times", QuackCounter.Quacks);
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }


    }
}
