namespace TDD_Training;

public class NextBiggerNumber
{
    public int FindNextBiggerNumber(int n)
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

        var decreasingIndex = FindFirstDecreasingIndex(digits);

        if (decreasingIndex < 0)
        {
            return -1;
        }

        var biggerIndex = FindFirstIndexBiggerThanDecreasingIndex(digits, decreasingIndex);

        SwapDigit(digits, decreasingIndex, biggerIndex);

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

    private static int FindFirstIndexBiggerThanDecreasingIndex(int[] digits, int decreasingIndex)
    {
        var j = digits.Length - 1;

        while (digits[j] <= digits[decreasingIndex])
        {
            j--;
        }

        return j;
    }

    private static int FindFirstDecreasingIndex(int[] digits)
    {
        var i = digits.Length - 2;

        while (i >= 0 && digits[i] >= digits[i + 1])
        {
            i--;
        }

        return i;
    }

    private static int[] NumberSeparateToArray(int n)
    {
        var digits = n.ToString().Select(c => c - '0').ToArray();
        return digits;
    }
}