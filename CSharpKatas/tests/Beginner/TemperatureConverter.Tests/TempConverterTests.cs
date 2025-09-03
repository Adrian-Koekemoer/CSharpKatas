using Exercises.Beginner.TemperatureConverter;
using System;
using Xunit;

namespace Exercises.Beginner.TemperatureConverter.Tests;

public class TempConverterTests
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    public void CelsiusToFahrenheit_Works(double celsius, double expected)
    {
        var actual = TempConverter.CelsiusToFahrenheit(celsius);
        Assert.True(actual == expected, $"CelsiusToFahrenheit({celsius}) should return {expected}, but got {actual}");
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    public void FahrenheitToCelsius_Works(double fahrenheit, double expected)
    {
        var actual = TempConverter.FahrenheitToCelsius(fahrenheit);
        Assert.True(actual == expected, $"FahrenheitToCelsius({fahrenheit}) should return {expected}, but got {actual}");
    }
}
