namespace Algo.Tree;

public class BinaryTree
{
    public BinaryTree()
    {
    }

    public string BreadthFirst(Node<string> input)
    {
        string result = "";
        if (input == null) return result;
        
        Queue<Node<string>> queue = new Queue<Node<string>>();
        queue.Enqueue(input);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            result += current.Value;
            
            if (current.Left!=null) queue.Enqueue(current.Left);
            if (current.Right!=null) queue.Enqueue(current.Right);
        }

        return result;
    }

    public string DepthFirstAlternative(Node<string> input)
    {
        if (input == null) return "";

        var left = DepthFirstAlternative(input.Left);
        var right = DepthFirstAlternative(input.Right);
        return $"{input.Value}{left}{right}";
    }

    public string DepthFirst(Node<string> input)
    {
        string result = "";
        
        if (input == null) return result; 
        
        Stack<Node<string>> stack = new Stack<Node<string>>();
        stack.Push(input);

        while (stack.Count > 0)
        {
            var currentNode = stack.Pop();
            result += currentNode.Value;
            
            if (currentNode.Right != null)
            {
                stack.Push(currentNode.Right);
            }
            if (currentNode.Left != null)
            {
                stack.Push(currentNode.Left);
            }
        }

        return result;
    }
}

public class Node<T>
{
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }
    public T Value { get; set; }
    
    public Node(T value, Node<T> left, Node<T> right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
    public Node(T value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
    
    public Node(T value, Node<T> left)
    {
        Value = value;
        Left = left;
        Right = null;
    }
}
//       a
//    b      e
//  c   d  f   g