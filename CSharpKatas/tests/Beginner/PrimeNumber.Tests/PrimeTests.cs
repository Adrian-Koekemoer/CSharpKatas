using Exercises.Beginner.PrimeNumber;
using Xunit;

namespace Exercises.Beginner.PrimeNumber.Tests;

public class PrimeTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(17, true)]
    [InlineData(18, false)]
    [InlineData(1, false)]
    [InlineData(0, false)]
    [InlineData(-7, false)]
    public void IsPrime_Works(int n, bool expected)
    {
        var actual = Prime.IsPrime(n);
        Assert.True(actual == expected, $"IsPrime({n}) should return {expected}, but got {actual}");
    }
}
