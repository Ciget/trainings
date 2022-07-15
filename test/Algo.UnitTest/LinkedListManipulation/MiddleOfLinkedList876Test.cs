using Algo.LinkedListManipulation;
using FluentAssertions;

namespace Algo.UnitTest.LinkedListManipulation;

public class MiddleOfLinkedList876Test
{
    private MiddleOfLinkedList876 _engine = new MiddleOfLinkedList876();

    [Fact]
    public void ShouldReturnMiddle()
    {
        ListNode root = new ListNode(1,
            new ListNode(2,
                new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8, new ListNode(9, new ListNode(10, new ListNode(11, new ListNode(12))))))))))));
        var node = _engine.MiddleNodeAlternative(root);
        node.val.Should().Be(7);
            
    }
    
}