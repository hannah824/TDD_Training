using FluentAssertions;

namespace TDD_Training.Tests;

public class RunnersMeetingsTest
{
    private RunnersMeetings _runnersMeetings;

    [SetUp]
    public void SetUp()
    {
        _runnersMeetings = new RunnersMeetings();
    }

    [TestCase(new[] { 1, 4, 2 }, new[] { 27, 18, 24 }, 3)]
    [TestCase(new[] { 1, 2 }, new[] { 2, 1 }, 2)]
    [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 3)]
    [TestCase(new[] { 1, 2 }, new[] { 1, 1 }, -1,TestName = "No meetings possible")]
    public void should_return_correct_max_meeting_cardinality(int[] startPosition, int[] speed, int expected)
    {
        var result = _runnersMeetings.FindMaxMeetingCardinality(startPosition, speed);

        result.Should().Be(expected);
    }
}