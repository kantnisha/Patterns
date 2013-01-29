using System;

namespace Factory.Code
{
    public interface IDough
    {
         
    }
    public interface ISouce
    {
        
    }
    public interface ICheese
    {

    }

    public class ThinCrustDough : IDough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Thin Crust Dough");
        }
    }

    public class ThickCrustDough : IDough
    {
        public ThickCrustDough()
        {
            Console.WriteLine("Thick Crust Dough");
        }
    }

    public class MarinaraSouce : ISouce
    {
        public MarinaraSouce()
        {
            Console.WriteLine("Marinara Sauce");
        }
    }

    public class PepperoniSouce : ISouce
    {
        public PepperoniSouce()
        {
            Console.WriteLine("Pepperoni Sauce");
        }
    }

    public class NYChese : ICheese
    {
        public NYChese()
        {
            Console.WriteLine("NY Chese");
        }
    }

    public class ChicagoChese : ICheese
    {
        public ChicagoChese()
        {
            Console.WriteLine("Chicago Chese");
        }
    }
}