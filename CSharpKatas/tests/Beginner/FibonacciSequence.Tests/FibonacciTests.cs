using Exercises.Beginner.FibonacciSequence;
using Xunit;

namespace Exercises.Beginner.FibonacciSequence.Tests;

public class FibonacciTests
{
    [Theory]
    [InlineData(1, new int[] { 0 })]
    [InlineData(2, new int[] { 0, 1 })]
    [InlineData(5, new int[] { 0, 1, 1, 2, 3 })]
    public void Generate_Works(int n, int[] expected)
    {
        var actual = Fibonacci.Generate(n);
        Assert.Equal(expected, actual);
    }
}
