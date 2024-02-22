using LeetCodeSolution.src._1TwoSum;

class Program
{
    public static void Main(string[] args)
    {
        #region 1. Two Sum
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = Solution.TwoSum(nums, target);

        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        #endregion
    }
}