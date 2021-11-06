namespace ObserverPattern.Interfaces
{
    public interface ISubjectService
    {
        void Attach(IObserverService observer);

        void Detach(IObserverService observer);

        void Notify();
    }
}