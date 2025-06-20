using FluentAssertions;

namespace TDD_Training.Tests;

public class CountingDuplicatesTests
{
    private CountingDuplicates _countingDuplicates;

    [SetUp]
    public void SetUp()
    {
        _countingDuplicates = new CountingDuplicates();
    }

    [TestCase("abcde", 0)]
    [TestCase("aabbcde", 2)]
    [TestCase("aabBcde", 2)]
    [TestCase("indivisibility", 1)]
    [TestCase("Indivisibilities", 2)]
    [TestCase("aA11", 2)]
    [TestCase("ABBA", 2)]
    [TestCase("", 0)]
    public void normal_case(string input, int expected)
    {
        AssertDuplicateCount(input, expected);
    }

    private void AssertDuplicateCount(string input, int expected)
    {
        var result = _countingDuplicates.Count(input);
        result.Should().Be(expected);
    }
}