namespace DesignPattern.Infrastructure.Services.AbstractFactory
{
    public abstract class ContinentAbstractFactory
    {
        public abstract HerbivoreAbstractFactory CreateHerbivoreAbstractFactory();

        public abstract CarnivoreAbstractFactory CreateCarnivoreAbstractFactory();
    }
    
}