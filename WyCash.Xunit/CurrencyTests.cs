using System;
using Xunit;

using WyCash.Lib;

namespace WyCash.Xunit
{
    public class CurrencyTests
    {
        [Fact]
        public void TestAllEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.True(new Dollar(5).Equals(new Dollar(6)));
            Assert.True(new Franc(5).Equals(new Franc(5)));
            Assert.True(new Franc(5).Equals(new Franc(5)));
        }

        [Fact]
        public void TestDollarMultiplication()
        {
            Money fiveDollars = new Dollar(5);
            Assert.Equal(new Dollar(5), fiveDollars);
            Assert.Equal(new Dollar(10), fiveDollars.MultiplyBy(2));
            Assert.Equal(new Dollar(15), fiveDollars.MultiplyBy(3));
        }

        [Fact]
        public void TestDollarEquality(){
            Money fiveDollars = new Dollar(5);
            Money anotherFiveDollars = new Dollar(5);
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