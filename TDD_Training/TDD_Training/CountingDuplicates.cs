namespace TDD_Training;

using System.Linq;

public class CountingDuplicates
{
    public int Count(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        return input.ToLower()
                   .GroupBy(c => c)
                   .Count(g => g.Count() > 1);
    }
} 