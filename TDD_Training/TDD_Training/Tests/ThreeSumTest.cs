using FluentAssertions;

namespace TDD_Training.Tests;

public class ThreeSumTests
{
    private ThreeSum _threeSum;

    [SetUp]
    public void SetUp()
    {
        _threeSum = new ThreeSum();
    }

    [Test]
    public void should_return_correct_triplets_for_example_1()
    {
        var nums = new[] { -1, 0, 1, 2, -1, -4 };
        var expected = new[] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } };

        var result = _threeSum.FindTriplets(nums);

        AssertTriplets(result, expected);
    }

    [Test]
    public void should_return_empty_for_example_2()
    {
        var nums = new[] { 0, 1, 1 };

        var result = _threeSum.FindTriplets(nums);

        result.Should().BeEmpty();
    }

    [Test]
    public void should_return_single_triplet_for_example_3()
    {
        var nums = new[] { 0, 0, 0 };
        var expected = new[] { new[] { 0, 0, 0 } };

        var result = _threeSum.FindTriplets(nums);

        AssertTriplets(result, expected);
    }

    private static void AssertTriplets(List<List<int>> result, int[][] expected)
    {
        result.Count.Should().Be(expected.Length);
        
        foreach (var triplet in result)
        {
            triplet.Count.Should().Be(3);
            triplet.Sum().Should().Be(0);
        }
        
        foreach (var expectedTriplet in expected)
        {
            result.Should().ContainEquivalentOf(expectedTriplet);
        }
    }
} 