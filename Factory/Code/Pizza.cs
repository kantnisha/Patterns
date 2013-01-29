using System;
using System.Collections.Generic;

namespace Factory.Code
{
    public abstract class Pizza
    {
        protected string Name;
        protected IDough Dough;
        protected ISouce Sauce;
        protected ICheese Cheese;
        protected List<string> Toppings = new List<string>();

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual string GetName()
        {
            return Name;
        }

        public virtual void SetName(string name)
        {
            Name = name;
        }
    }
}