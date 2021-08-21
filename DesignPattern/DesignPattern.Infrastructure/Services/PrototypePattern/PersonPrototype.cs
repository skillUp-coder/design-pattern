using DesignPattern.Infrastructure.Models.PrototypePattern;

#pragma warning disable 618

namespace DesignPattern.Infrastructure.Services.PrototypePattern
{
    public class PersonPrototype
    {
        // ReSharper disable once MemberCanBePrivate.Global
        public readonly Person Person;

        public PersonPrototype(Person person)
        {
            Person = person;
        }


        public PersonPrototype ShallowCopy()
        {
            // ReSharper disable once SuspiciousTypeConversion.Global
            var erw = (PersonPrototype)this.MemberwiseClone();
            return erw;
        }

        public PersonPrototype DeepCopy()
        {
            if (this.MemberwiseClone() is not PersonPrototype personClone) return new PersonPrototype(new Person());
            personClone.Person.Info = new Info(this.Person.Info.Id);
            personClone.Person.Name = string.Copy(Person.Name);

            return personClone;
        }
    }
}