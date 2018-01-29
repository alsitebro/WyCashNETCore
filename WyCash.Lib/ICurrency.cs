using System;

namespace WyCash.Lib
{
    public interface ICurrency : IEquatable<ICurrency>
    {
         decimal Amount { get; }
         ICurrency MultiplyBy(int multiplier);
    }
}