using DesignPattern.Infrastructure.Enums.FactoryMethodEnums;

namespace DesignPattern.Infrastructure.Services.FactoryMethod
{
    /// <summary>
    ///     Class for initializing Debit card.
    /// </summary>
    public class InitializeDebitCard : FactoryMethodService
    {
        private int _creditLimit;
        private int _annualCharge;

        /// <summary>
        ///     Initializes a new instance of the <see cref="InitializeDebitCard" /> class.
        /// </summary>
        /// <param name="creditLimit">The credit limit.</param>
        /// <param name="annualCharge">The annual charge.</param>
        public InitializeDebitCard(int creditLimit, 
                                   int annualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = annualCharge;
        }
        
        /// <inheritdoc/>
        public override CardType CardType => CardType.DebitCard;

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
    ///     Class for initializing Debit card factory.
    /// </summary>
    public class DebitCardFactory : CardsFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualCharge;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DebitCardFactory" /> class.
        /// </summary>
        /// <param name="creditLimit">The credit limit.</param>
        /// <param name="annualCharge">The annual charge.</param>
        public DebitCardFactory(int creditLimit, 
                                int annualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = annualCharge;
        }
        
        /// <inheritdoc/>
        public override FactoryMethodService FactoryMethodService()
        {
            return new InitializeDebitCard(this._creditLimit, this._annualCharge);
        }
    }
}