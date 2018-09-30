using System;
using System.Collections.Generic;

namespace WyCash.Lib
{
    public abstract class Money
    {
        protected decimal _amount;
        protected Currency _currency;

        public Money(decimal amount, Currency currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public decimal Amount { get => _amount; }

        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return _amount.Equals(money.Amount) 
                && this.GetType().Equals(money.GetType());
        }

        public override int GetHashCode() => this.GetHashCode();

        public static Money GetFrancs(decimal amount)
        {
            return new Franc(amount);
        }

        public static Money GetDollars(decimal amount)
        {
            return new Dollar(amount);
        }

        public abstract Money MultiplyBy(int multiplier);
        public Currency GetCurrency() => _currency;
    }
}