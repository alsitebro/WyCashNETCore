namespace WyCash.Lib
{
    public class Franc : Money
    {
        public Franc(decimal amount, string currency)
        : base(amount, currency){}

        public override Money MultiplyBy(int multiplier)
        {
            return Money.GetFrancs(_amount * multiplier);
        }
    }
}