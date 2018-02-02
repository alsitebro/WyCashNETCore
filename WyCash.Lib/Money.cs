using System;

namespace WyCash.Lib
{
    public class Money : ICurrency
    {
        protected decimal _amount;
        public Money(decimal amount)
        {
            _amount = amount;
        }

        public decimal Amount { get => _amount; }

        public ICurrency MultiplyBy(int multiplier)
        {
            return new Money(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return _amount.Equals(money.Amount);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}