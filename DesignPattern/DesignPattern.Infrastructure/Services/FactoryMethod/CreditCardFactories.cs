using DesignPattern.Infrastructure.Enums.FactoryMethodEnums;

namespace DesignPattern.Infrastructure.Services.FactoryMethod
{
    /// <summary>
    ///     Class for initializing Credit card.
    /// </summary>
    public class InitializeCreditCard : FactoryMethodService
    {
        private int _creditLimit;
        private int _annualCharge;

        /// <summary>
        ///     Initializes a new instance of the <see cref="InitializeCreditCard" /> class.
        /// </summary>
        /// <param name="creditLimit">The credit limit.</param>
        /// <param name="annualCharge">The annual charge.</param>
        public InitializeCreditCard(int creditLimit, 
                                    int annualCharge)
        {
            this._annualCharge = annualCharge;
            this._creditLimit = creditLimit;
        }

        /// <inheritdoc/>
        public override CardType CardType => CardType.CreditCard;

        /// <inheritdoc/>
        public override int CreditLimit
        {
            get => this._creditLimit;
            set => this._creditLimit = value;
        }

        /// <inheritdoc/>
        public override int AnnualCharge
        {
            get => this._annualCharge;
            set => this._annualCharge = value;
        }
    }

    /// <summary>
    ///     Class for initializing Credit card factory.
    /// </summary>
    public class CreditCardFactory : CardsFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualCharge;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CreditCardFactory" /> class.
        /// </summary>
        /// <param name="creditLimit">The credit limit.</param>
        /// <param name="annualCharge">The annual charge.</param>
        public CreditCardFactory(int creditLimit, 
                                 int annualCharge)
        {
            this._annualCharge = annualCharge;
            this._creditLimit = creditLimit;
        }

        /// <inheritdoc/>
        public override FactoryMethodService FactoryMethodService()
        {
            return new InitializeCreditCard(this._creditLimit, this._annualCharge);
        }
    }
}