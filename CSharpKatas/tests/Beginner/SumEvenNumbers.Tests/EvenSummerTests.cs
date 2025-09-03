using Exercises.Beginner.SumEvenNumbers;
using Xunit;

namespace Exercises.Beginner.SumEvenNumbers.Tests;

public class EvenSummerTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 12)]
    [InlineData(new int[] { 1, 3, 5 }, 0)]
    [InlineData(new int[] { 2, 4, 6 }, 12)]
    public void Sum_Works(int[] numbers, int expected)
    {
        var actual = EvenSummer.Sum(numbers);
        Assert.True(actual == expected, $"Sum should return {expected}, but got {actual}");
    }
}
