using LeetCodeSolution.src;
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

        #region 9. Palindrome Number
        bool ispalindrome = _9PalindromeNumber.IsPalindrome(121);
       
        Console.WriteLine("9. Palindrome Number: " + ispalindrome);
        #endregion

        #region 13. Roman to Integer
        int roman = _13RomantoInteger.RomanToInt("III");
        Console.WriteLine("13.Roman to Integer: " + roman);
        #endregion
    }
}