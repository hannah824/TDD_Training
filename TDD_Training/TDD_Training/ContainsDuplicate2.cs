namespace TDD_Training;

public class ContainsDuplicate2
{
    public bool ContainsDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.TryGetValue(nums[i], out var lastIndex))
            {
                if (CalculateAbsDiff(i, lastIndex) <= k)
                {
                    return true;
                }
            }
            dict[nums[i]] = i;
        }

        return false;
    }

    private static int CalculateAbsDiff(int i, int lastIndex)
    {
        return Math.Abs(i - lastIndex);
    }
}