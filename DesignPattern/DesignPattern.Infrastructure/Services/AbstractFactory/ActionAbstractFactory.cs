namespace DesignPattern.Infrastructure.Services.AbstractFactory
{
    public class ActionAbstractFactory
    {
        private readonly HerbivoreAbstractFactory _herbivoreAbstractFactory;
        private readonly CarnivoreAbstractFactory _carnivoreAbstractFactory;

        public ActionAbstractFactory(ContinentAbstractFactory factory)
        {
            this._herbivoreAbstractFactory = factory.CreateHerbivoreAbstractFactory();
            this._carnivoreAbstractFactory = factory.CreateCarnivoreAbstractFactory();
        }

        public void SetupAction()
        {
            this._carnivoreAbstractFactory.Eat(this._herbivoreAbstractFactory);
        }
    }
}