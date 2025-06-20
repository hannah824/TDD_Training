namespace TDD_Training;

public class BandNameGenerator
{
    public string Generate(string noun)
    {
        if (string.IsNullOrEmpty(noun))
        {
            return string.Empty;
        }

        if (IsStartAndEndLetterSame(noun))
        {
            return FirstLetterToUpper(noun) + noun[1..];
        }
        else
        {
            return "The " + FirstLetterToUpper(noun);
        }
    }

    private static string FirstLetterToUpper(string noun)
    {
        return char.ToUpper(noun[0]) + noun[1..];
    }

    private static bool IsStartAndEndLetterSame(string noun)
    {
        return noun[0] == noun[^1];
    }
} 