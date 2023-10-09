namespace Algo.Tree.DFS;

//104. Maximum Depth of Binary Tree
public class MaxDepthOfTree
{
    public int MaxDepth(TreeNode root)
    {
        return GetLevel(root, 0);
    }

    private int GetLevel(TreeNode node, int level)
    {
        if (node != null)
        {
            return Math.Max(GetLevel(node.left, level + 1), GetLevel(node.right, level + 1));
        }
        return level;
    }
}