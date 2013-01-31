using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using State.Code;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var gm = new GumballMachine(200);

            for (int i = 0; i < 200; i++)
            {
                gm.InsertQuarter();
                gm.TurnCrank();
            }

          

            Console.ReadKey();
        }
    }
}
