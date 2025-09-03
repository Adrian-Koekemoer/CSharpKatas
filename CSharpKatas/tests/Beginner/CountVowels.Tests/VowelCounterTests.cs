using Exercises.Beginner.CountVowels;
using Xunit;

namespace Exercises.Beginner.CountVowels.Tests;

public class VowelCounterTests
{
    [Theory]
    [InlineData("hello", 2)]
    [InlineData("world", 1)]
    [InlineData("xyz", 0)]
    [InlineData("AEIOU", 5)]
    public void Count_Works(string input, int expected)
    {
        var actual = VowelCounter.Count(input);
        Assert.True(actual == expected, $"Count({input}) should return {expected}, but got {actual}");
    }
}
