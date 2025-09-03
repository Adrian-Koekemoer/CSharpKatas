using System.Linq;
using System.Reflection;
using Xunit;

namespace Exercises.Beginner.ReverseString.Tests;

public class StringReverserTests
{
    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("world", "dlrow")]
    [InlineData("", "")]
    [InlineData("a", "a")]
    public void Reverse_Works(string input, string expected)
    {
        var actual = StringReverser.Reverse(input);
        Assert.True(actual == expected, $"Reverse({input}) should return {expected}, but got {actual}");
    }

    [Fact]
    public void Reverse_ShouldNotUseBuiltInReverse()
    {
        var method = typeof(StringReverser).GetMethod("Reverse");
        var ilBytes = method!.GetMethodBody()!.GetILAsByteArray();
        var ilText = string.Join(" ", ilBytes.Select(b => b.ToString("X2")));

        // Fail if IL contains a call to "Reverse"
        if (ilText.Contains("Reverse"))
        {
            Assert.Fail("Your solution uses String.Reverse (or Array.Reverse), which is not allowed for this exercise.");
        }
    }
}
