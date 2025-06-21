using FluentAssertions;

namespace TDD_Training.Tests;

public class PlayWithTwoStringsTest
{
    private PlayWithTwoStrings _playWithTwoStrings;

    [SetUp]
    public void SetUp()
    {
        _playWithTwoStrings = new PlayWithTwoStrings();
    }

    [TestCase("abc", "cde", "abCCde")]
    [TestCase("ab", "aba", "aBABA")]
    [TestCase("abab", "bababa", "ABABbababa")]
    [TestCase("Hello", "World", "HeLLOWOrld", TestName = "should_handle_mixed_case_strings")]
    [TestCase("1!a@", "1#A$", "1!A@1#a$", TestName = "should_handle_special_characters_and_numbers")]
    [TestCase("", "abc", "abc", TestName = "should_return_another_string_when_one_is_empty")]
    [TestCase("a bc", "cde", "a bCCde", TestName = "should_handle_spaces_in_strings")]
    public void should_return_correct_combined_string(string s1, string s2, string expected)
    {
        var result = _playWithTwoStrings.CombineStrings(s1, s2);

        result.Should().Be(expected);
    } 
}