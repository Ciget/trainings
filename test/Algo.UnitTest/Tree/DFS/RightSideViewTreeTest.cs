using Algo.Tree;
using Algo.Tree.BFS;
using FluentAssertions;

namespace Algo.UnitTest.Tree.DFS;

public class RightSideViewTreeTest
{
    private RightSideViewTree _engine = new RightSideViewTree();

    [Fact]
    public void ShouldFindRightNodes()
    {
        TreeNode root = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), 
            new TreeNode(3, null, new TreeNode(4)));
        
        var result = _engine.RightSideView(root);
        result.Should().NotBeNull();
        result.Should().HaveCount(3);
        result[0].Should().Be(1);
        result[1].Should().Be(3);
        result[2].Should().Be(4);
    }
    
    [Fact]
    public void ShouldFindRightNodes2()
    {
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4)), 
            new TreeNode(3));
        
        var result = _engine.RightSideView(root);
        result.Should().NotBeNull();
        result.Should().HaveCount(3);
        result[0].Should().Be(1);
        result[1].Should().Be(3);
        result[2].Should().Be(4);
    }
    
    [Fact]
    public void ShouldFindNull()
    {
        var result = _engine.RightSideView(null);
        result.Should().BeEmpty();
    }
}