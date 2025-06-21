using FluentAssertions;

namespace TDD_Training.Tests;

public class NextBiggerNumberTests
{
    private NextBiggerNumber _nextBiggerNumber;

    [SetUp]
    public void SetUp()
    {
        _nextBiggerNumber = new NextBiggerNumber();
    }

    [TestCase(12, 21)]
    [TestCase(513, 531)]
    [TestCase(2017, 2071)]
    public void should_return_next_bigger_number_for_input(int input, int expected)
    {
        var result = _nextBiggerNumber.FindNextBiggerNumber(input);

        result.Should().Be(expected);
    }

    [TestCase(9)]
    [TestCase(111)]
    [TestCase(531)]
    public void should_return_minus_one_when_no_bigger_number_exists(int input)
    {
        var result = _nextBiggerNumber.FindNextBiggerNumber(input);

        result.Should().Be(-1);
    }
} 