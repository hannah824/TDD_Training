using FluentAssertions;

namespace TDD_Training;

public class DeadAntsTest
{
    private DeadAnts _deadAnts;

    [SetUp]
    public void SetUp()
    {
        _deadAnts = new DeadAnts();
    }

    [TestCase("..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..", 0)]
    [TestCase("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t", 3)]
    [TestCase("", 0)]
    public void normal_case(string input, int expected)
    {
        var result = _deadAnts.CountDeadAnts(input);

        result.Should().Be(expected);
    }
}