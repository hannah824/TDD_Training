namespace TDD_Training;

public class DeadAnts
{
    public int CountDeadAnts(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        return CountAllAnts(input) - CountCompleteAnts(input);
    }

    private int CountAllAnts(string input)
    {
        var totalA = input.Count(c => c == 'a');
        var totalN = input.Count(c => c == 'n');
        var totalT = input.Count(c => c == 't');
        return Math.Max(Math.Max(totalA, totalN), totalT);
    }

    private int CountCompleteAnts(string input)
    {
        var count = 0;

        for (var i = 0; i <= input.Length - 3; i++)
        {
            if (input.Substring(i, 3) == "ant")
            {
                count++;
            }
        }

        return count;
    }
}