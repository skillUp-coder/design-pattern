using System;
using DesignPattern.Infrastructure.Models.PrototypePattern;
using DesignPattern.Infrastructure.Services.PrototypePattern;

namespace DesignPattern.App.Services.PrototypeSetUp
{
    public static class SetUpPrototype
    {
        public static void SetUp()
        {
            Console.WriteLine("Prototype pattern:");
            
            var personPrototype = new PersonPrototype(SetUpPersonValue());

            var personShallowCopy = personPrototype.ShallowCopy();
            var personDeepCopy = personPrototype.DeepCopy();

            Console.Write($"personShallowCopy -");
            ViewValue(personShallowCopy);

            Console.Write($"personDeepCopy - ");
            ViewValue(personDeepCopy);
        }

        private static void ViewValue(PersonPrototype person)
        {
            Console.WriteLine
                ($" Id {person.Person.Info.Id}, Name {person.Person.Name},  BirthDay {person.Person.BirthDay}, Age {person.Person.Age}");
        }

        private static Person SetUpPersonValue()
        {
            return new Person()
            {
                Age = 212,
                BirthDay = Convert.ToDateTime("1776-01-01"),
                Name = "Test User",
                Info = new Info(Guid.NewGuid())
            };
        }
    }
}