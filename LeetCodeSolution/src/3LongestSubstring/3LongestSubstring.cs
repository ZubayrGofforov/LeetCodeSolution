namespace LeetCodeSolution.src._3LongestSubstring
{
    public class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            HashSet<char> uniqueChars = new HashSet<char>();

            for (int right = 0; right < n; right++)
            {
                uniqueChars.Add(s[right]);
            }

            return uniqueChars.Count;
        }
    }
}
