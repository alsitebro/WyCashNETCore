using System;
using Xunit;

using WyCash.Lib;

namespace WyCash.Xunit
{
    public class CurrencyTests
    {
        [Fact]
        public void TestDollarMultiplication()
        {
            ICurrency fiveDollars = new Dollar(5);
            Assert.Equal(new Dollar(5), fiveDollars);
            Assert.Equal(new Dollar(10), fiveDollars.MultiplyBy(2));
            Assert.Equal(new Dollar(15), fiveDollars.MultiplyBy(3));
        }

        [Fact]
        public void TestDollarEquality(){
            ICurrency fiveDollars = new Dollar(5);
            ICurrency anotherFiveDollars = new Dollar(5);
            Assert.True(fiveDollars.Equals(anotherFiveDollars));
        }

        [Fact]
        public void TestFrancsMultiplication()
        {
            ICurrency fiveFrancs = new Franc(5);
            Assert.Equal(new Franc(10), fiveFrancs.MultiplyBy(2));
            Assert.Equal(new Franc(15), fiveFrancs.MultiplyBy(3));
        }
    }
}