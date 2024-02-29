namespace LeetCodeSolution.src.From1To20
{
    public class _3LongestSubstring
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
