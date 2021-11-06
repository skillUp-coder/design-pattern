using System;
using System.Collections.Generic;
using System.Threading;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Services
{
    public class SubjectService : ISubjectService
    {
        public int State { get; set; } = -0;
        
        private readonly List<IObserverService> _observerServices;

        public SubjectService()
        {
            _observerServices = new List<IObserverService>();
        }
        
        public void Attach(IObserverService observer)
        {
            Console.WriteLine(nameof(Attach));
            _observerServices.Add(observer);
        }

        public void Detach(IObserverService observer)
        {
            _observerServices.Remove(observer);
            Console.WriteLine(nameof(Detach));
        }
        
        public void Notify()
        {
            Console.WriteLine(nameof(Notify));

            foreach (var observer in _observerServices)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine(nameof(SomeBusinessLogic));
            State = new Random().Next(0, 10);
            Thread.Sleep(15);

            Console.WriteLine(State);
            Notify();
        }
    }
}