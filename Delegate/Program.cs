using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Delegate.Code;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new EventTest();
            test.Click();
            Console.ReadKey();
        }
    }
}
