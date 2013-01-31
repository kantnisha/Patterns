using System;
using State.Interface;

namespace State.Code
{
    public class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter his inserted");
            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("No quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You can insert quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }

    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        private Random _rand = new Random();

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            var temp = _rand.Next(10);
            if (temp  == 0 && _gumballMachine.Count > 1)
            {
                Console.WriteLine("Random: {0}", temp);
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }

    public class SoldState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get another guball!");
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }
        }
    }

    public class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You trened, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumballs dispensed");
        }
    }

    public class WinnerState : IState
    {
        private GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Error");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Error");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Error");
        }

        public void Dispense()
        {
            Console.WriteLine("Winner");
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
            else
            {
                _gumballMachine.ReleaseBall();
                if (_gumballMachine.Count == 0)
                {
                    _gumballMachine.SetState(_gumballMachine.SoldOutState);
                }
            }
        }
    }
}