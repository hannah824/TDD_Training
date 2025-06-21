using FluentAssertions;

namespace TDD_Training.Tests;

public class SumStringsAsNumbersTest
{
    private SumStringsAsNumbers _sumStringsAsNumbers;

    [SetUp]
    public void SetUp()
    {
        _sumStringsAsNumbers = new SumStringsAsNumbers();
    }

    [TestCase("1", "2", "3")]
    [TestCase("123", "456", "579")]
    [TestCase("999", "1", "1000")]
    [TestCase("0", "0", "0")]
    [TestCase("", "123", "123")]
    [TestCase("123", "", "123")]
    [TestCase("999999999", "1", "1000000000")]
    public void should_return_correct_sum_for_valid_input(string s1, string s2, string expected)
    {
        var result = _sumStringsAsNumbers.SumStrings(s1, s2);

        result.Should().Be(expected);
    }
}