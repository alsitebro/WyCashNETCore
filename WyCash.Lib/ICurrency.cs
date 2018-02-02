using System;

namespace WyCash.Lib
{
    public interface ICurrency : IEquatable<object>
    {
         decimal Amount { get; }
         ICurrency MultiplyBy(int multiplier);
    }
}