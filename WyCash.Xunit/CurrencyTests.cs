using System;
using WyCash.Lib;
using Xunit;

namespace WyCash.Xunit
{
    public class CurrencyTests
    {
        [Fact]
        public void Equality()
        {
            Assert.True(Money.GetDollars(5).Equals(new Dollar(5)));
            Assert.False(Money.GetDollars(5).Equals(new Dollar(6)));
            Assert.True(Money.GetFrancs(5).Equals(new Franc(5)));
            Assert.False(Money.GetFrancs(5).Equals(new Franc(6)));
        }

        [Fact]
        public void DollarMultiplication()
        {
            Money fiveDollars = Money.GetDollars(5);
            Assert.Equal(Money.GetDollars(5), fiveDollars);
            Assert.Equal(Money.GetDollars(10), fiveDollars.MultiplyBy(2));
            Assert.Equal(Money.GetDollars(15), fiveDollars.MultiplyBy(3));
        }

        [Fact]
        public void FrancsMultiplication()
        {
            Money fiveFrancs = Money.GetFrancs(5);
            Assert.Equal(Money.GetFrancs(10), fiveFrancs.MultiplyBy(2));
            Assert.Equal(Money.GetFrancs(15), fiveFrancs.MultiplyBy(3));
        }

        [Fact]
        public void CrossCurrencyEquality()
        {
            Assert.False(Money.GetFrancs(5).Equals(Money.GetDollars(5)));
        }

        [Fact]
        public void CheckCurrency()
        {
            Assert.Equal(Currency.USD, Money.GetDollars(1).GetCurrency());
            Assert.Equal(Currency.CHf, Money.GetFrancs(1).GetCurrency());
        }
    }
}