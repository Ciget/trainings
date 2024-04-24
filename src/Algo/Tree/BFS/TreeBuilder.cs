namespace Algo.Tree.BFS;

public class TreeBuilder
{
    Node<int> CreateTree(int[] inputArray)
    {
        if (inputArray.Length == 0) return null;
        Node<int> root = new Node<int>(inputArray[0]);

        for (int i = 1; i < inputArray.Length; i++)
        {
            FindNode(root, inputArray[i]);
        }

        return root;
    }

    Node<int> FindNode(Node<int> root, int value)
    {
        if (root == null) return null;

        if (root.Value == value)
        {
            InsertNode(root, value);
        }
        else if (root.Value>value)
        {
            FindNode(root.Right, value);
        }
        else FindNode(root.Left, value);
    }

    void InsertNode(Node<int> parent, int value)
    {
        if (parent == null) return;
        
        Node<int> newNode = new Node<int>(value);

        if (parent.Value <= value)
        {
            newNode.Left = parent.Left;
        }
        else
        {
            new
        }
    }


}