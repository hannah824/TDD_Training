using FluentAssertions;

namespace TDD_Training.Tests;

public class Rot13Test
{
    private Rot13 _rot13;

    [SetUp]
    public void SetUp()
    {
        _rot13 = new Rot13();
    }

    [TestCase("EBG13 rknzcyr.", "ROT13 example.")]
    [TestCase("This is my first ROT13 excercise!", "Guvf vf zl svefg EBG13 rkprepvfr!")]
    [TestCase("HELLO", "URYYB",TestName = "should_return_rot13_for_uppercase_string")]
    [TestCase("hello", "uryyb", TestName = "should_return_rot13_for_lowercase_string")]
    [TestCase("HEllo", "URyyb", TestName = "should_return_rot13_for_mixed_case_string")]
    [TestCase("123", "123", TestName = "should_return_same_for_numbers")]
    [TestCase("!@#", "!@#", TestName = "should_return_same_for_special_characters")]
    [TestCase("", "", TestName = "should_return_empty_string_for_empty_input")]
    public void should_return_correct_rot13_encoding(string input, string expected)
    {
        var result = _rot13.Encode(input);

        result.Should().Be(expected);
    }
}