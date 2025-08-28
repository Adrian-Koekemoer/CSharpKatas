using Exercises.Gcd;
using Xunit;

namespace Exercises.Gcd.Tests;

public class GcdTests
{
    [Theory]
    [InlineData(54, 24, 6)]
    [InlineData(24, 54, 6)]
    [InlineData(5, 0, 5)]
    [InlineData(0, 5, 5)]
    [InlineData(-48, 18, 6)]
    [InlineData(48, -18, 6)]
    public void Gcd_StandardCases_ReturnsExpected(int a, int b, int expected)
    {
        var actual = GcdMath.Gcd(a, b);
        Assert.True(actual == expected, $"Gcd({a}, {b}) should be {expected}, but got {actual}");
    }

    [Fact]
    public void Gcd_ZeroZero_Throws()
    {
        var ex = Assert.Throws<ArgumentException>(() => GcdMath.Gcd(0, 0));
        Assert.Contains("0, 0", ex.Message);
    }
}
