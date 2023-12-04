namespace Algo.Tree.DFS;

//236. Lowest Common Ancestor of a Binary Tree
public class CommonAncestor
{
    //Time complexity: O(n)
    // Space complexity: O(n)
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null) return null;

        if (root.val == p.val || root.val == q.val) return root;
        
        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);

        if (left != null && right != null) return root;
        return left ?? right;
    }
}