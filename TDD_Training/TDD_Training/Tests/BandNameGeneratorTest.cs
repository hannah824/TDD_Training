using FluentAssertions;

namespace TDD_Training.Tests;

public class BandNameGeneratorTests
{
    private BandNameGenerator _bandNameGenerator;

    [SetUp]
    public void SetUp()
    {
        _bandNameGenerator = new BandNameGenerator();
    }

    [Test]
    public void should_add_the_before_noun_for_input()
    {
        const string input = "dolphin";

        AssertBandName(input, "The Dolphin");
    }

    [Test]
    public void should_repeat_noun_when_first_and_last_letter_are_same()
    {
        const string input = "alaska";

        AssertBandName(input, "Alaskalaska");
    }
    
    [Test]
    public void should_return_empty_string_for_input_empty_string()
    {
        var input = string.Empty;

        AssertBandName(input, string.Empty);
    }

    private void AssertBandName(string input, string expected)
    {
        var result = _bandNameGenerator.Generate(input);
        result.Should().Be(expected);
    }
} 