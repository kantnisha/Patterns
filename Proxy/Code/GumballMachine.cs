using System;
using State.Code;

namespace Proxy.Code
{
    public class GumballMonitor
    {
        private GumballMachine _gumballMachine;
        
        public GumballMonitor(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        
        public void Report()
        {
            Console.WriteLine("Gumball Machine: {0}", _gumballMachine.Location);
            Console.WriteLine("Current inventory: {0} gumballs", _gumballMachine.Count);
            Console.WriteLine("Current state: {0}", _gumballMachine.State);
        }
    }
}