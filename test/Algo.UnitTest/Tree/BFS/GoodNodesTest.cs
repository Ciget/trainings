using Algo.Tree;
using Algo.Tree.BFS;
using FluentAssertions;

namespace Algo.UnitTest.BFS;

public class GoodNodesTest
{
    private CountGoodNodes _engine = new CountGoodNodes();
    
    [Fact]
    public void ShouldBePositive()
    {
        TreeNode node = new TreeNode(3, new TreeNode(1, new TreeNode(3)),
            new TreeNode(4, new TreeNode(1), new TreeNode(5)));
        _engine.GoodNodes(node).Should().Be(4);
    }
}