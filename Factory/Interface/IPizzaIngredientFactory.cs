using Factory.Code;

namespace Factory.Interface
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISouce CreateSauce();
        ICheese CreateCheese();
    }
}