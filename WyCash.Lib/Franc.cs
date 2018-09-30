namespace WyCash.Lib
{
    public class Franc : Money
    {
        public Franc(decimal amount)
        : base(amount, Currency.CHf){}

        public override Money MultiplyBy(int multiplier)
        {
            return Money.GetFrancs(_amount * multiplier);
        }
    }
}