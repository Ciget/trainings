namespace Algo.Stack;

public class RemovingStars
{
    //2390. Removing Stars From a String
    
    public string RemoveStars(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (var i in s)
        {
            if (i != '*') stack.Push(i);
            else stack.TryPop(out _);
        }

        return string.Concat(stack.Reverse());
    }
}