using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxy.Code;
using State.Code;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var gm = new GumballMachine(200, "I.Raskovoi 24");
            var monitor = new GumballMonitor(gm);

            monitor.Report();

            Console.ReadKey();
        }
    }
}
