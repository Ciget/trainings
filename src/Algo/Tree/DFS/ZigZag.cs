namespace Algo.Tree.DFS;

//1372. Longest ZigZag Path in a Binary Tree
public class ZigZag
{
    public int LongestZigZag(TreeNode root)
    {
        return Math.Max(CheckNode(root, true, 0),
        CheckNode(root, false, 0))-1;
    }

    //true - left
    //false - right
    private int CheckNode(TreeNode node, bool direction, int level)
    {
        if (node == null)  return level;
        
        
        int currentPathLevel = CheckNode(direction?node.left:node.right, !direction, level + 1);
        int altPathLevel = CheckNode(direction?node.right:node.left, direction, 1);
        return Math.Max(currentPathLevel, altPathLevel);
    }
}