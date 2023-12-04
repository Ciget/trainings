namespace Algo.Tree.DFS;

//437. Path Sum III
public class TreeNodesSum
{
    public int PathSum(TreeNode root, long targetSum)
    {
        if (root == null) return 0;

        return CalcSum(root, targetSum) + PathSum(root.left, targetSum) + PathSum(root.right, targetSum);
    }

    private int CalcSum(TreeNode node, long target)
    {
        if (node == null) return 0;

        return (node.val == target ? 1 : 0) 
                                          + CalcSum(node.left, target - node.val) 
                                          + CalcSum(node.right, target - node.val);
    }
}