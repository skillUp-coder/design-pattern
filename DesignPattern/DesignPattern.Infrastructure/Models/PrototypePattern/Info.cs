using System;

namespace DesignPattern.Infrastructure.Models.PrototypePattern
{
    public class Info
    {
        public Guid Id { get; set; }

        public Info(Guid id)
        {
            this.Id = id;
        }
    }
}