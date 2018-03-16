namespace AnotherObserverPattern
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void DeregisterObserver(IObserver o);
        void NotifyObservers();
    }
}