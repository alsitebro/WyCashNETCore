namespace WyCash.Lib
{
    public class Franc : ICurrency
    {
        public Franc(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; }

        public bool Equals(ICurrency other) => ((Franc)other).Amount.Equals(this.Amount);

        public ICurrency MultiplyBy(int multiplier)
        {
           return new Franc(Amount * multiplier);
        }
    }
}