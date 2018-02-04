using System;

namespace WyCash.Lib 
{
    public class Dollar : Money
    {
        public Dollar(decimal amount, string currency) 
        : base(amount, currency){}

        public override Money MultiplyBy(int multiplier)
        {
            return Money.GetDollars(_amount * multiplier);
        }
    }
}