using DesignPattern.App.Services.AbstractFactorySetUp;
using DesignPattern.App.Services.FactoryMethodSetUp;
using DesignPattern.App.Services.PrototypeSetUp;
using DesignPattern.App.Services.SingletonSetUp;

namespace DesignPattern.App
{
    internal static class Program
    {
        private static void Main()
        {
            SetUpFactoryMethod.SetUp();
            
            SetUpAbstractFactory.SetUp();
            
            SetUpSingleton.SetUp();
            
            SetUpPrototype.SetUp();
        }
    }
}