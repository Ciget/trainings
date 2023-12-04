using Algo.Tree;
using Algo.Tree.DFS;
using FluentAssertions;

namespace Algo.UnitTest.Tree.DFS;

public class ZigZagTest
{
    private ZigZag _engine = new ZigZag();

    [Fact]
    public void ShouldFindPath()
    {
        TreeNode _root = new TreeNode(1,null,
            new TreeNode(1, new TreeNode(1, null, new TreeNode(1, null, new TreeNode(1))),new TreeNode(1)));

        _engine.LongestZigZag(_root).Should().Be(3);
    }

}