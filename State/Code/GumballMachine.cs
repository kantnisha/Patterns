using System;
using State.Interface;

namespace State.Code
{
    public class GumballMachine
    {
        private readonly IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _winnerState;

        private IState _state;
        private int _count;
        private string _location;

        public GumballMachine(int numberGumballs, string location)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);
            _count = numberGumballs;
            _location = location;
            if (_count > 0)
            {
                _state = _noQuarterState;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count != 0)
            {
                _count--;
            }
            Console.WriteLine("Balls: {0}", _count);
        }

        public IState SoldOutState
        {
            get { return _soldOutState; }
        }

        public IState NoQuarterState
        {
            get { return _noQuarterState; }
        }

        public IState HasQuarterState
        {
            get { return _hasQuarterState; }
        }

        public IState SoldState
        {
            get { return _soldState; }
        }

        public IState WinnerState
        {
            get { return _winnerState; }
        }

        public int Count
        {
            get { return _count; }
        }

        public string Location
        {
            get { return _location; }
        }

        public IState State
        {
            get { return _state; }
        }
    }
}