namespace TDD_Training;

internal class NextSmallerNumber
{
    public int FindNextSmallerNumber(int n)
    {
        if (n < 0)
        {
            return -1;
        }

        var digits = NumberSeparateToArray(n);

        if (digits.Length <= 1)
        {
            return -1;
        }

        var increasingIndex = FindFirstIncreasingIndex(digits);

        if (increasingIndex < 0)
        {
            return -1;
        }

        var smallerIndex = FindFirstIndexSmallerThanIncreasingIndex(digits, increasingIndex);

        SwapDigit(digits, increasingIndex, smallerIndex);

        if (digits[0] == 0)
        {
            return -1;
        }

        return ArrayToNumber(digits);
    }

    private static int ArrayToNumber(int[] digits)
    {
        return int.Parse(string.Join("", digits));
    }

    private static void SwapDigit<T>(T[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }

    private static int FindFirstIndexSmallerThanIncreasingIndex(int[] digits, int increasingIndex)
    {
        var j = digits.Length - 1;

        while (digits[j] >= digits[increasingIndex])
        {
            j--;
        }

        return j;
    }

    private static int FindFirstIncreasingIndex(int[] digits)
    {
        var i = digits.Length - 2;

        while (i >= 0 && digits[i] <= digits[i + 1])
        {
            i--;
        }

        return i;
    }

    private static int[] NumberSeparateToArray(int n)
    {
        return n.ToString().Select(c => c - '0').ToArray();
    }
}