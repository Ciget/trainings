using Algo.Tree;
using Algo.Tree.DFS;
using FluentAssertions;

namespace Algo.UnitTest.Tree.DFS;

public class TreeNodesSumTest
{
    private TreeNodesSum _engine = new TreeNodesSum();

    [Fact]
    public void ShouldFoundTarget()
    {
        TreeNode _root = new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(3), new TreeNode(-2)), new TreeNode(2, null, new TreeNode(1))), new TreeNode(-3, null, new TreeNode(11)));
        _engine.PathSum(_root, 8).Should().Be(3);
    }
    
    [Fact]
    public void ShouldNotFoundTarget()
    {
        TreeNode _root = new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(3), new TreeNode(-2)), new TreeNode(2, null, new TreeNode(1))), new TreeNode(-3, null, new TreeNode(11)));
        _engine.PathSum(_root, 0).Should().Be(0);
    }
    
    [Fact]
    public void ShouldFoundTarget2()
    {
        TreeNode _root = new TreeNode(1,
            new TreeNode(-2, new TreeNode(1), new TreeNode(2, null, new TreeNode(1))),
            new TreeNode(-3, null, new TreeNode(11)));
        _engine.PathSum(_root, 8).Should().Be(3);
    }

}
