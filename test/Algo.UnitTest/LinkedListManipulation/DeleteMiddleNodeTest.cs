using Algo.LinkedListManipulation;
using FluentAssertions;

namespace Algo.UnitTest.LinkedListManipulation;

public class DeleteMiddleNodeTest
{
    private DeleteMiddleNode _engine = new DeleteMiddleNode();

    [Fact]
    public void ShouldBePositive()
    {
        ListNode node = new ListNode(1,
            new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6)))))));

        var result = _engine.DeleteMiddle(node);
        //result.val.Should().Be()
    }
}