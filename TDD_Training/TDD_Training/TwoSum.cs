namespace TDD_Training;

using System.Collections.Generic;

public class TwoSum
{
    public int[] FindIndices(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if (dict.TryGetValue(complement, out var index))
            {
                return [index, i];
            }

            dict[nums[i]] = i;
        }

        return [];
    }
}