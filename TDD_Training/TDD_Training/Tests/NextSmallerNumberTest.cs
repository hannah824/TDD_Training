using FluentAssertions;

namespace TDD_Training.Tests;

public class NextSmallerNumberTest
{
    private NextSmallerNumber _nextSmallerNumber;

    [SetUp]
    public void SetUp()
    {
        _nextSmallerNumber = new NextSmallerNumber();
    }

    [TestCase(21, 12)]
    [TestCase(531, 513)]
    [TestCase(2071, 2017)]
    public void should_return_next_smaller_number_for_input(int input, int expected)
    {
        var result = _nextSmallerNumber.FindNextSmallerNumber(input);

        result.Should().Be(expected);
    }

    [TestCase(9)]
    [TestCase(111)]
    [TestCase(135)]
    [TestCase(1027)]
    [TestCase(-11)]
    public void should_return_minus_one_when_no_smaller_number_exists(int input)
    {
        var result = _nextSmallerNumber.FindNextSmallerNumber(input);

        result.Should().Be(-1);
    }
}