using System;

namespace WyCash.Lib
{
    public class Dollar : Money
    {
        public Dollar(decimal amount) 
        : base(amount, Currency.USD){}

        public override Money MultiplyBy(int multiplier)
        {
            return Money.GetDollars(_amount * multiplier);
        }
    }
}