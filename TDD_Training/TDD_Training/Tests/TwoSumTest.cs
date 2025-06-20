using FluentAssertions;

namespace TDD_Training.Tests;

public class TwoSumTests
{
    private TwoSum _twoSum;

    [SetUp]
    public void SetUp()
    {
        _twoSum = new TwoSum();
    }

    [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void should_return_correct_indices_for_valid_input(int[] nums, int target, int[] expected)
    {
        var result = _twoSum.FindIndices(nums, target);

        ResultShouldMatch(nums, target, expected, result);
    }

    [TestCase(new[] { 1, 2, 3 }, 7, new int[] { })]
    [TestCase(new[] {1}, 5, new int[] { })]
    public void should_return_empty_when_no_result(int[] nums, int target, int[] expected)
    {
        var result = _twoSum.FindIndices(nums, target);

        result.Should().BeEmpty();
    }

    private static void ResultShouldMatch(int[] nums, int target, int[] expected, int[] result)
    {
        result.Length.Should().Be(2);
        result.Should().Contain(expected[0]);
        result.Should().Contain(expected[1]);
        (nums[result[0]] + nums[result[1]]).Should().Be(target);
    }
}