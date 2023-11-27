namespace Algo.Tree.BFS;

public class CountGoodNodes
{
    //1448. Count Good Nodes in Binary Tree
    public int GoodNodes(TreeNode root)
    {
        return CheckNode(root, root.val);
    }

    private int CheckNode(TreeNode node, int num = int.MinValue)
    {
        if (node == null) return 0;
        int count = 0;
        if(node.val >= num){
            count = 1;
            num = node.val;
        }
        return CheckNode(node.left, num) + CheckNode(node.right, num) +count;
    }
}