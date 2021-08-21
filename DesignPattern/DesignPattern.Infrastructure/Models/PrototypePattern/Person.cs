using System;

namespace DesignPattern.Infrastructure.Models.PrototypePattern
{
    public class Person
    {
        public string Name { get; set; }
        
        public int Age { get; set; }

        public DateTime BirthDay { get; set; }

        public Info Info { get; set; }
    }
}