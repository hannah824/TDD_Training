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
        if (IsUpper(c))
        {
            return Rotate13(c, 'A');
        }
        
        if (IsLower(c))
        {
            return Rotate13(c, 'a');
        }
        
        return c;
    }

    private static char Rotate13(char c, char baseChar)
    {
        return (char)((c - baseChar + 13) % 26 + baseChar);
    }

    private static bool IsLower(char c)
    {
        return c >= 'a' && c <= 'z';
    }

    private static bool IsUpper(char c)
    {
        return c >= 'A' && c <= 'Z';
    }
}