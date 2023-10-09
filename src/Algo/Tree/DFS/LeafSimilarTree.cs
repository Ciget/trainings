namespace Algo.Tree.DFS;

//872. Leaf-Similar Trees
public class LeafSimilarTree
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        List<int> result1 = new List<int>();
        List<int> result2 = new List<int>();

        CheckTree(root1, result1);
        CheckTree(root2, result2);

        if (result1.Count != result2.Count) return false;

        for(int i=0; i<result1.Count; i++)
        {
            if (result1[i] != result2[i]) return false;
        }

        return true;
    }

    private void CheckTree(TreeNode node, List<int> result)
    {
        if (node == null) return;
        if (node.left == null && node.right == null)
        {
            result.Add(node.val);
        }

        CheckTree(node.left, result);
        CheckTree(node.right, result);
    }
}