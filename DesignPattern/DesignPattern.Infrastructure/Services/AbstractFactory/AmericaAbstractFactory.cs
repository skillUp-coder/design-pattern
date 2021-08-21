namespace DesignPattern.Infrastructure.Services.AbstractFactory
{
    public class AmericaAbstractFactory : ContinentAbstractFactory
    {
        public override HerbivoreAbstractFactory CreateHerbivoreAbstractFactory()
        {
            return new Bison();
        }

        public override CarnivoreAbstractFactory CreateCarnivoreAbstractFactory()
        {
            return new Wolf();
        }
    }
}