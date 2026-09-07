public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stk = new Stack<int>(temperatures.Length);
        int[] res = new int[temperatures.Length];
        for(int i = temperatures.Length - 1; i >= 0; i--)
        {
            while(!(stk.Count == 0))
            {
                if(temperatures[stk.Peek()] > temperatures[i])
                {
                    res[i] = stk.Peek() - i;
                    break;
                }
                else
                {
                    stk.Pop();
                }
            }
            stk.Push(i);
        }
        return res;
    }
}
