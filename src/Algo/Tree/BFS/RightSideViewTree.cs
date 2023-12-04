namespace Algo.Tree.BFS;

public class RightSideViewTree
{
    public IList<int> RightSideView(TreeNode root)
    {
        List<int> results = new List<int>();

        if (root == null) return results;
        
        CheckNode(root, results, 0);
        
        return results;
    }

    private void CheckNode(TreeNode node, List<int> list, int level)
    {
        if (node == null) return;
        
        if (list.Count == level) list.Add(node.val);
        
        CheckNode(node.right, list, level +1);
        CheckNode(node.left, list,level +1);
    }
}