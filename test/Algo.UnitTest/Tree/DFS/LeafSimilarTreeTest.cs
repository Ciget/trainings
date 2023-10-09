using Algo.Tree;
using Algo.Tree.DFS;
using FluentAssertions;

namespace Algo.UnitTest.Tree.DFS;

public class LeafSimilarTreeTest
{
    private LeafSimilarTree _engine = new LeafSimilarTree();
    
    [Fact]
    public void ShouldBePositive()
    {
        TreeNode node1 = new TreeNode(3,
            new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))),
        new TreeNode(1, new TreeNode(9), new TreeNode(8))
            );

        TreeNode node2 = new TreeNode(3,
            new TreeNode(5, new TreeNode(6), new TreeNode(7)),
            new TreeNode(1, new TreeNode(4), new TreeNode(2, new TreeNode(9), new TreeNode(8)))
        );
        _engine.LeafSimilar(node1, node2).Should().BeTrue();
    }
}