namespace TDD_Training;

internal class PlayWithTwoStrings
{
    public string CombineStrings(string s1, string s2)
    {
        var s1Result = s1;
        var s2Result = s2;

        foreach (var c in s1)
        {
            s2Result = SwapCaseInString(s2Result, c);
        }

        foreach (char c in s2)
        {
            s1Result = SwapCaseInString(s1Result, c);
        }

        return s1Result + s2Result;
    }

    private static string SwapCaseInString(string str, char targetChar)
    {
        return new string(str.Select(c => 
            char.ToLower(c) == char.ToLower(targetChar) ? SwapCase(c) : c).ToArray());
    }

    private static char SwapCase(char c)
    {
        return char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
    }
}