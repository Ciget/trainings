using Algo.Tree;
using Algo.Tree.DFS;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace Algo.UnitTest.Tree.DFS;

public class MaxDepthOfTreeTest
{
    private MaxDepthOfTree _engine = new MaxDepthOfTree();

    [Fact]
    public void ShouldBePositive()
    {
        TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        
        _engine.MaxDepth(root).Should().Be(3);
    }
}