using FluentAssertions;

namespace TDD_Training.Tests;

public class ContainsDuplicate3Test
{
    private ContainsDuplicate3 _containsDuplicate3;

    [SetUp]
    public void SetUp()
    {
        _containsDuplicate3 = new ContainsDuplicate3();
    }

    [TestCase(new[] { 1, 2, 3, 1 }, 3, 0, true)]
    [TestCase(new[] { 1, 5, 9, 1, 5, 9 }, 2, 3, false)]
    public void should_return_correct_result_for_input(int[] nums, int indexDiff, int valueDiff, bool expected)
    {
        var result = _containsDuplicate3.ContainsDuplicate(nums, indexDiff, valueDiff);

        result.Should().Be(expected);
    } 
    [Test]
    public void should_return_false_for_empty_array()
    {
        var result = _containsDuplicate3.ContainsDuplicate([], 1, 1);

        result.Should().BeFalse();
    }
}