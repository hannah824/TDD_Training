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
            return char.ToUpper(noun[0]) + noun[1..] + noun[1..];
        }
        else
        {
            return "The " + char.ToUpper(noun[0]) + noun[1..];
        }
    }

    private static bool IsStartAndEndLetterSame(string noun)
    {
        return noun[0] == noun[^1];
    }
} 