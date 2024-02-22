namespace LeetCodeSolution.src
{
    public static class _9PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            string numStr = x.ToString();
            string reversedStr = new string(numStr.Reverse().ToArray());
            return numStr.Equals(reversedStr);
        }
    }
}
