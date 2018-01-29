using System;
using Xunit;

using WyCash.Lib;

namespace WyCash.Xunit
{
    public class CurrencyTests
    {
        [Fact]
        public void TestCurrencyMultiplication()
        {
            ICurrency fiveDollars = new Dollar(5);
            Assert.Equal(new Dollar(5), fiveDollars);
            Assert.Equal(new Dollar(10), fiveDollars.MultiplyBy(2));
            Assert.Equal(new Dollar(15), fiveDollars.MultiplyBy(3));
        }

        [Fact]
        public void TestCurrencyEquality(){
            ICurrency fiveDollars = new Dollar(5);
            ICurrency anotherFiveDollars = new Dollar(5);
            Assert.True(fiveDollars.Equals(anotherFiveDollars));
        }
    }
}