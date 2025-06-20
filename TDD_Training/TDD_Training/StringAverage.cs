namespace TDD_Training;

public class StringAverage
{
    private static readonly Dictionary<string, int> StringToNumber = new(StringComparer.OrdinalIgnoreCase)
    {
        { "zero", 0 }, { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 },
        { "five", 5 }, { "six", 6 }, { "seven", 7 }, { "eight", 8 }, { "nine", 9 }
    };

    private static readonly Dictionary<int, string> NumberToString = new()
    {
        { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" },
        { 5, "five" }, { 6, "six" }, { 7, "seven" }, { 8, "eight" }, { 9, "nine" }
    };

    public string Calculate(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return "n/a";
        }

        try
        {
            var numbers = input.Split(" ")
                .Select(n => StringToNumber[n])
                .ToList();

            var average = numbers.Sum() / numbers.Count;
            return NumberToString.GetValueOrDefault(average, "n/a");
        }
        catch (Exception)
        {
            return "n/a";
        }
    }
}