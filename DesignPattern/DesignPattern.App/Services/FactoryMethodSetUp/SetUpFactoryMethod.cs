using System;
using DesignPattern.Infrastructure.Services.FactoryMethod;

namespace DesignPattern.App.Services.FactoryMethodSetUp
{
    /// <summary>
    ///     Class for initializing setup Factory method.
    /// </summary>
    public static class SetUpFactoryMethod
    {
        /// <summary>
        ///     Initialize Setup for Factories method.
        /// </summary>
        public static void SetUp()
        {
            Console.WriteLine("Factory Method:");
            
            SetUpCreditCardFactory();
            SetUpDebitCardFactory();

            Console.WriteLine();
        }

        private static void SetUpCreditCardFactory() 
        {
            CardsFactory cardsFactory = new CreditCardFactory(22323, 4343);
            
            if (cardsFactory == null)
            {
                throw new ArgumentNullException(nameof(cardsFactory));
            }

            var factoryMethodService = cardsFactory.FactoryMethodService();
            Console.WriteLine($"Result: type - {factoryMethodService.CardType}, credit limit - {factoryMethodService.CreditLimit}, annual charge - {factoryMethodService.AnnualCharge}");
        }
        
        private static void SetUpDebitCardFactory() 
        {
            CardsFactory cardsFactory = new DebitCardFactory(3423, 56756);
            
            if (cardsFactory == null)
            {
                throw new ArgumentNullException(nameof(cardsFactory));
            }

            var factoryMethodService = cardsFactory.FactoryMethodService();
            Console.WriteLine($"Result: type - {factoryMethodService.CardType}, credit limit - {factoryMethodService.CreditLimit}, annual charge - {factoryMethodService.AnnualCharge}");
        }
    }
}