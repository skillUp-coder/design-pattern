using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Services
{
    public class ExampleObserverService : IObserverService
    {
        public void Update(ISubjectService subject)
        {
            const string messageTemplate = "{0}: {1}";
            if (((SubjectService) subject).State is 0 or >= 2)
            {
                Console.WriteLine(string.Format(messageTemplate, nameof(ExampleObserverService), nameof(Update)));
            }
        }
    }
}