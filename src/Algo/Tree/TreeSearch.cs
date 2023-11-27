namespace Algo.Tree;

public class TreeSearch
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        var current = root;

        while (current!=null)
        {
            if (current.val == val) return current;

            if (current.val > val)
            {
                current = current.left;
            }
            else current = current.right;
        }

        return null;
    }
}