using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter.Code;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverage coffee = new Coffee();
            CaffeineBeverage tea = new Tea();

            coffee.PrepareRecipe();
            tea.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
