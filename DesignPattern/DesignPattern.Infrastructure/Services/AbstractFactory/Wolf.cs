using System;

namespace DesignPattern.Infrastructure.Services.AbstractFactory
{
    public class Wolf : CarnivoreAbstractFactory
    {
        public override void Eat(HerbivoreAbstractFactory herbivore)
        {
            Console.WriteLine($"{this.GetType().Name} eats {herbivore.GetType().Name}");
        }
    }
}