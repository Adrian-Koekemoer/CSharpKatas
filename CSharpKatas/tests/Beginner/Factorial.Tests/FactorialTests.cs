using Exercises.Factorial;
using Xunit;

namespace Exercises.Factorial.Tests;

public class FactorialTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(5, 120)]
    [InlineData(10, 3628800)]
    public void Factorial_ValidInputs_ReturnsExpected(int n, long expected)
    {
        var actual = FactorialCalc.Factorial(n);
        Assert.True(actual == expected, $"Factorial({n}) should be {expected}, but got {actual}");
    }

    [Fact]
    public void Factorial_Negative_Throws()
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => FactorialCalc.Factorial(-1));
        Assert.Contains("n", ex.Message);
    }
}
