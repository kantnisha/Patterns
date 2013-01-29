using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Code;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            
            Console.WriteLine("{0} ${1}", beverage.GetDescription(), beverage.Cost());
            beverage.SetSize(3);
            Console.WriteLine("{0} ${1}", beverage.GetDescription(), beverage.Cost());

            Beverage beverage2 = new Mocha(beverage);
            Console.WriteLine("{0} ${1}", beverage2.GetDescription(), beverage2.Cost());
            beverage2 = new Mocha(beverage2);
            Console.WriteLine("{0} ${1}", beverage2.GetDescription(), beverage2.Cost());

            
            beverage2.SetSize(2);
            Console.WriteLine("{0} ${1}", beverage2.GetDescription(), beverage2.Cost());
            Console.ReadKey();
        }
    }
}
