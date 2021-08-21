using System;
using DesignPattern.Infrastructure.Services.AbstractFactory;

namespace DesignPattern.App.Services.AbstractFactorySetUp
{
    public static class SetUpAbstractFactory
    {
        public static void SetUp()
        {
            Console.WriteLine("Abstract Factory:");
            
            var america = new AmericaAbstractFactory();
            var action = new ActionAbstractFactory(america);
            action.SetupAction();
        }
    }
}