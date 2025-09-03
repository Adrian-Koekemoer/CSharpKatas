using Exercises.Beginner.FizzBuzz;
using Xunit;

namespace Exercises.Beginner.FizzBuzz.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void Generate_UpTo16_MatchesRules()
    {
        var list = FizzBuzzGen.Generate(16);
        Assert.True(list.Count == 16, $"Expected 16 elements, but got {list.Count}");

        for (int i = 1; i <= 16; i++)
        {
            string expected = (i % 15 == 0) ? "FizzBuzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString();
            string actual = list[i - 1];
            Assert.True(actual == expected, $"FizzBuzz output incorrect at position {i}: expected '{expected}', got '{actual}'");
        }
    }

    [Fact]
    public void Generate_LessThanOne_Throws()
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => FizzBuzzGen.Generate(0));
        Assert.Contains("n", ex.Message);
    }
}
