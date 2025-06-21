namespace TDD_Training;

public class ContainsDuplicate3
{
    public bool ContainsDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j <= GetIndexRange(nums, indexDiff, i); j++)
            {
                if (CalculateAbsDiff(nums, i, j) <= valueDiff)
                {
                    return true;
                }
            }
        }
        
        return false;
    }

    private static int CalculateAbsDiff(int[] nums, int i, int j)
    {
        return Math.Abs(nums[i] - nums[j]);
    }

    private static int GetIndexRange(int[] nums, int indexDiff, int i)
    {
        return Math.Min(i + indexDiff, nums.Length - 1);
    }
}