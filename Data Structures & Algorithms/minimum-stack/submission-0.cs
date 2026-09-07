public class MinStack {
    Stack<int> main = new Stack<int>();
    Stack<int> min = new Stack<int>();
    public MinStack() {
        
    }
    
    public void Push(int val) {
        main.Push(val);
        if(min.Count != 0)
        {
            min.Push(Math.Min(min.Peek(), val));
        }
        else
        {
            min.Push(val);
        }
    }
    
    public void Pop() {
        main.Pop();
        min.Pop();
    }
    
    public int Top() {
        return main.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}
