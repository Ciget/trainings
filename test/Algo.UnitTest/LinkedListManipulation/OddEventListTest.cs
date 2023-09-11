using Algo.LinkedListManipulation;
using FluentAssertions;

namespace Algo.UnitTest.LinkedListManipulation;

public class OddEventListTest
{
    private OddEvenLinkedList _engine = new OddEvenLinkedList();

    [Fact]
    public void ShouldBePositive()
    {
        ListNode node = new ListNode(1,
            new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

        var result = _engine.OddEvenList(node);
        result.val.Should().Be(1);
        result.next.val.Should().Be(3);
        result.next.next.val.Should().Be(5);
        result.next.next.next.val.Should().Be(2);
        result.next.next.next.next.val.Should().Be(4);
    }
}