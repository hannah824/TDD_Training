namespace TDD_Training;

public class ThreeSum
{
    public List<List<int>> FindTriplets(int[] nums)
    {
        var result = new List<List<int>>();

        if (nums.Length < 3)
        {
            return result;
        }

        Array.Sort(nums);

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (IsDuplicateWithFirstNumber(nums, i))
            {
                continue;
            }

            FindPairsForCurrentNumber(nums, i, result);
        }

        return result;
    }

    private static bool IsDuplicateWithFirstNumber(int[] nums, int i)
    {
        return i > 0 && nums[i] == nums[i - 1];
    }

    private static void FindPairsForCurrentNumber(int[] nums, int firstIndex, List<List<int>> result)
    {
        var secondIndex = firstIndex + 1;
        var lastIndex = nums.Length - 1;

        while (secondIndex < lastIndex)
        {
            var sum = nums[firstIndex] + nums[secondIndex] + nums[lastIndex];

            if (sum == 0)
            {
                result.Add([nums[firstIndex], nums[secondIndex], nums[lastIndex]]);
                SkipDuplicates(nums, ref secondIndex, ref lastIndex);
                secondIndex++;
                lastIndex--;
            }
            else if (sum < 0)
            {
                secondIndex++;
            }
            else
            {
                lastIndex--;
            }
        }

    }

    private static void SkipDuplicates(int[] nums, ref int secondIndex, ref int lastIndex)
    {
        while (secondIndex < lastIndex && nums[secondIndex] == nums[secondIndex + 1])
        {
            secondIndex++;
        }

        while (secondIndex < lastIndex && nums[lastIndex] == nums[lastIndex - 1])
        {
            lastIndex--;
        }
    }
}