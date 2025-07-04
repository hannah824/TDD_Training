using FluentAssertions;

namespace TDD_Training.Tests;

public class Tests
{
    private StringAverage _stringAverage;

    [SetUp]
    public void SetUp()
    {
        _stringAverage = new StringAverage();
    }

    [Test]
    public void return_average_number_for_input_normal_string()
    {
        const string input = "zero nine five two";

        AssertAverage(input, "four");
    }

    [Test]
    public void return_na_for_input_empty_string()
    {
        var input = string.Empty;

        AssertAverage(input, "n/a");
    }

    [Test]
    public void return_na_for_input_number_greater_than_nine()
    {
        const string input = "zero nine five ten";

        AssertAverage(input, "n/a");
    }

    [Test]
    public void return_average_number_for_input_string_with_uppercase()
    {
        const string input = "ZERO NINE FIVE TWO";

        AssertAverage(input, "four");
    }
    [Test]
    public void return_na_for_input_invalid_string()
    {
        const string input = "how are you";

        AssertAverage(input, "n/a");
    }

    private void AssertAverage(string input, string expected)
    {
        var result = _stringAverage.Calculate(input);
        result.Should().Be(expected);
    }
}