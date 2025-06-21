using FluentAssertions;

namespace TDD_Training.Tests;

public class ContainsDuplicate2Tests
{
    private ContainsDuplicate2 _containsDuplicate2;

    [SetUp]
    public void SetUp()
    {
        _containsDuplicate2 = new ContainsDuplicate2();
    }

    [TestCase(new[] { 1, 2, 3, 1 }, 3, true)]
    [TestCase(new[] { 1, 0, 1, 1 }, 1, true)]
    [TestCase(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    [TestCase(new[] { -1, 0, -1, -1 }, 1, true)]
    public void should_return_correct_result_for_input(int[] nums, int k, bool expected)
    {
        var result = _containsDuplicate2.ContainsDuplicate(nums, k);

        result.Should().Be(expected);
    }
    [Test]
    public void should_return_false_for_empty_array()
    {
        var result = _containsDuplicate2.ContainsDuplicate([], 1);

        result.Should().BeFalse();
    }
}