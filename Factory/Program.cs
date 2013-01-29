using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory.Code;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("First pizza {0}", pizza.GetName());

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Second pizza {0}", pizza.GetName());

            Console.ReadKey();
        }
    }
}
