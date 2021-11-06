namespace ObserverPattern.Interfaces
{
    public interface IObserverService
    {
        void Update(ISubjectService subject);
    }
}