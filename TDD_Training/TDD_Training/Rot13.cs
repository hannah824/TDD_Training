namespace TDD_Training;

internal class Rot13
{
    public string Encode(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        var result = new char[input.Length];

        for (var i = 0; i < input.Length; i++)
        {
            result[i] = DoTransform(input[i]);
        }

        return new string(result);
    }

    private char DoTransform(char c)
    {
        if (char.IsUpper(c))
        {
            return Rotate13(c, 'A');
        }

        if (char.IsLower(c))
        {
            return Rotate13(c, 'a');
        }

        return c;
    }

    private static char Rotate13(char c, char baseChar)
    {
        return (char)((c - baseChar + 13) % 26 + baseChar);
    }
}