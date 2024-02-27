public class Solution {
    public int EvalRPN(string[] tokens) 
    {
        Stack<int> stack = new Stack<int>();
        int a = 0;
        int b = 0;
        foreach(var s in tokens)
        {
            if(s == "+")
            {
                a = stack.Pop();
                b = stack.Pop();
                stack.Push((b + a));
            }
            else if(s == "-")
            {
                a = stack.Pop();
                b = stack.Pop();
                stack.Push((b - a));                
            }
            else if(s == "/")
            {
                a = stack.Pop();
                b = stack.Pop();
                stack.Push((b / a));                
            }
            else if(s == "*")
            {
                a = stack.Pop();
                b = stack.Pop();
                stack.Push((b * a));                
            }
            else
            {
                stack.Push(int.Parse(s));
            }
        }
        return stack.Peek();    
    }
}
