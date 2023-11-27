using Algo.Tree;
using FluentAssertions;

namespace Algo.UnitTest.Tree;

public class TreeSearchTest
{
    private TreeSearch _engine = new TreeSearch();
    private TreeNode secondNode;
    private TreeNode root;
    
    public TreeSearchTest()
    {
        secondNode = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        root = new TreeNode(4, secondNode, new TreeNode(7));
    }

    [Fact]
    public void ShouldFindNothing()
    {
        _engine.SearchBST(root, 5).Should().BeNull();
    }
    
    [Fact]
    public void ShouldFindNode()
    {
        _engine.SearchBST(root, 2).Should().Be(secondNode);
    }
}