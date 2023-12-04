using Algo.Tree;
using Algo.Tree.DFS;
using FluentAssertions;

namespace Algo.UnitTest.Tree.DFS;

public class CommonAncestorTest
{
    private CommonAncestor _engine = new CommonAncestor();

    [Fact]
    public void ShouldFindOneCommon()
    {
        //3,5,1,6,2,0,8,null,null,7,4
        TreeNode root = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))), new TreeNode(1, new TreeNode(0), new TreeNode(8)));
        var result = _engine.LowestCommonAncestor(root, new TreeNode(5), new TreeNode(1));
            result.Should().NotBeNull();
            result.val.Should().Be(3);
    }
}