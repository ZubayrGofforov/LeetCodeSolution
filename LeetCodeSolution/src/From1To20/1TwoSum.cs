namespace LeetCodeSolution.src.From1To20;
public static class _3_Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }

            numToIndex[nums[i]] = i;
        }

        throw new ArgumentException("No two numbers add up to the target.");
    }
}
