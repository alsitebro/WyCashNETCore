namespace WyCash.Lib
{
    public class Franc : Money
    {
        public Franc(decimal amount) : base(amount)
        {
            this.amount = amount;
        }

        public decimal Amount { get { return amount; } }

        
    }
}