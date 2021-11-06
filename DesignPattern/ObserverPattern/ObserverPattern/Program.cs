using ObserverPattern.Services;

namespace ObserverPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var subjectService = new SubjectService();
            var exampleObserverService = new ExampleObserverService();
            subjectService.Attach(exampleObserverService);

            subjectService.SomeBusinessLogic();
            subjectService.SomeBusinessLogic();
            subjectService.Detach(exampleObserverService);
            subjectService.SomeBusinessLogic();
        }
    }
}