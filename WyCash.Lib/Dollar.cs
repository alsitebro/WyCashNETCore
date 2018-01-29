using System;

namespace WyCash.Lib 
{
    public class Dollar : ICurrency
    {
        public Dollar(decimal amount) => Amount = amount;

        public decimal Amount { get; }

        public bool Equals(ICurrency other) => ((Dollar)other).Amount
                    .Equals(this.Amount);

        public ICurrency MultiplyBy(int multiplier) 
        { 
           return new Dollar(Amount * multiplier); 
        }
    }
}