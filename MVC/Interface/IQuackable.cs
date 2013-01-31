namespace MVC.Interface
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}