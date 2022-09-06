using System;
namespace Algo.Tree
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode (int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    /// <summary>
    /// Inorder traversal for binary tree.
    /// </summary>
    public class TreeTraversalInorder
    {
        Stack<TreeNode> _stack = new Stack<TreeNode>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            _stack.Clear();
            List<int> result = new List<int>();
            if (root == null) return result;
            var currentNode = root;

            while (currentNode!=null || _stack.Count > 0)
            {
                while (currentNode != null)
                {
                    _stack.Push(currentNode);
                    currentNode = currentNode.left;
                }

                currentNode = _stack.Pop();
                result.Add(currentNode.val);

                currentNode = currentNode.right;
            }

            return result;
        }
    }
}

