public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(s.Length);
        foreach(char c in s)
        {
            if(c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if(stack.Count == 0)
            {
                return false;
            }
            else if((c == ')' && stack.Pop() != '(') ||
            (c == ']' && stack.Pop() != '[') ||
            (c == '}' && stack.Pop() != '{') )
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
