using Algo.LinkedListManipulation;
using FluentAssertions;

namespace Algo.UnitTest.LinkedListManipulation;

public class ReverseListEngineTest
{
    private ReverseListEngine _engine = new ReverseListEngine();

    private ListNode _head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
    [Fact]
    public void ShouldBePositive()
    {
        var result =_engine.ReverseList(_head);
        result.val.Should().Be(5);
        result.next.val.Should().Be(4);
        result.next.next.val.Should().Be(3);
        result.next.next.next.val.Should().Be(2);
        result.next.next.next.next.val.Should().Be(1);
    }
}