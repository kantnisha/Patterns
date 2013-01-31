namespace MVC.Interface
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }

}