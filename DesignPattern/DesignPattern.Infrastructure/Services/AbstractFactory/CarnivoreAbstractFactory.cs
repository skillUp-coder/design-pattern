namespace DesignPattern.Infrastructure.Services.AbstractFactory
{
    public abstract class CarnivoreAbstractFactory
    {
        public abstract void Eat(HerbivoreAbstractFactory herbivore);
    }
}