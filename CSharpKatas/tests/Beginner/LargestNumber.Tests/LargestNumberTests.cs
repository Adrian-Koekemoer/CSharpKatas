using Exercises.Beginner.LargestNumber;
using Xunit;

namespace Exercises.Beginner.LargestNumber.Tests;

public class LargestNumberTests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 2, 99, 5 }, 99)]
    [InlineData(new int[] { -10, -20, -5 }, -5)]
    [InlineData(new int[] { 42 }, 42)]
    public void FindLargest_Works(int[] numbers, int expected)
    {
        var actual = LargestFinder.FindLargest(numbers);
        Assert.True(actual == expected, $"FindLargest should return {expected}, but got {actual}");
    }
}
