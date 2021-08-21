using DesignPattern.Infrastructure.Enums.FactoryMethodEnums;

namespace DesignPattern.Infrastructure.Services.FactoryMethod
{
    /// <summary>
    ///     Class for managing Factory method.
    /// </summary>
    public abstract class FactoryMethodService
    {
        /// <summary>
        ///     Gets or sets the Card type.
        /// </summary>
        /// <value>
        ///     The Card type.
        /// </value>
        public abstract CardType CardType { get; }
        
        /// <summary>
        ///     Gets or sets the Credit limit.
        /// </summary>
        /// <value>
        ///     The Credit limit.
        /// </value>
        public abstract int CreditLimit { get; set; }

        /// <summary>
        ///     Gets or sets the Annual charge.
        /// </summary>
        /// <value>
        ///     The Annual charge.
        /// </value>
        public abstract int AnnualCharge { get; set; }
    }

    /// <summary>
    ///     Class for managing Cards factory.
    /// </summary>
    public abstract class CardsFactory
    {
        /// <summary>
        ///   Retrieves an object for the Factory method.
        /// </summary>
        /// <returns>The object for matching Factory method.</returns>
        public abstract FactoryMethodService FactoryMethodService();
    }
}