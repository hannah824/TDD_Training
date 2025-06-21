namespace TDD_Training;

public class SumStringsAsNumbers
{
    public string SumStrings(string s1, string s2)
    {
        if (!string.IsNullOrEmpty(s1))
        {
            if (string.IsNullOrEmpty(s2))
            {
                return s1;
            }

            var result = new List<char>();
            var carry = 0;
            var i = s1.Length - 1;
            var j = s2.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                var sum = carry + GetDigit(s1, i) + GetDigit(s2, j);

                carry = sum / 10;
                result.Insert(0, DigitToChar(sum));
                i--;
                j--;
            }

            return new string(result.ToArray());
        }

        return s2;
    }

    private static char DigitToChar(int sum)
    {
        return (char)(sum % 10 + '0');
    }

    private static int GetDigit(string s, int i)
    {
        return i >= 0
            ? s[i] - '0'
            : 0;
    }
}