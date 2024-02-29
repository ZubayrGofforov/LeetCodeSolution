namespace LeetCodeSolution.src.From1To20;
public class _20ValidParentheses
{
    public static bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (stack.Count == 0 ||
                       (c == ')' && stack.Peek() != '(') ||
                       (c == '}' && stack.Peek() != '{') ||
                       (c == ']' && stack.Peek() != '['))
            {
                return false;
            }
            else
            {
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}
