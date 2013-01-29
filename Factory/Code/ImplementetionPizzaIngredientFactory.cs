using Factory.Interface;

namespace Factory.Code
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory 
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISouce CreateSauce()
        {
            return new MarinaraSouce();
        }

        public ICheese CreateCheese()
        {
            return new NYChese();
        }
    }

    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISouce CreateSauce()
        {
            return new PepperoniSouce();
        }

        public ICheese CreateCheese()
        {
            return new ChicagoChese();
        }
    }
}