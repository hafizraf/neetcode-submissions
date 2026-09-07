public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stk = new Stack<int>(tokens.Length); 
        foreach(string s in tokens)
        {
            if(s == "+" || s == "-" || s == "*" || s == "/")
            {
                int op2 = stk.Pop();
                int op1 = stk.Pop();
                switch(s) 
                {
                    case "*" :
                        op1 *= op2;
                        break;
                    case "/" :
                        op1 /= op2;
                        break;
                    case "+" :
                        op1 += op2;
                        break;
                    case "-" :
                        op1 -= op2;
                        break;
                    default : 
                        break;
                }
                stk.Push(op1);
            }
            else
            {
                stk.Push(Int32.Parse(s));
            }
        }   
        return stk.Pop(); 
    }
}
