namespace MVC.Interface
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}