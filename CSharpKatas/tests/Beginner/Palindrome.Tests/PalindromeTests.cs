using Exercises.Palindrome;
using Xunit;

namespace Exercises.Palindrome.Tests;

public class PalindromeTests
{
    [Theory]
    [InlineData("racecar", true)]
    [InlineData("RaceCar", true)]
    [InlineData("race car!", true)]
    [InlineData("", true)]
    [InlineData("hello", false)]
    [InlineData("No lemon, no melon", true)]
    public void IsPalindrome_Works(string input, bool expected)
    {
        var actual = PalindromeUtil.IsPalindrome(input);
        Assert.True(actual == expected, $"IsPalindrome(\"{input}\") should return {expected}, but got {actual}");
    }
}
