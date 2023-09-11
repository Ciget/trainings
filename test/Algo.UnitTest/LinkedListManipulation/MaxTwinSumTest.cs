using Algo.LinkedListManipulation;
using FluentAssertions;

namespace Algo.UnitTest.LinkedListManipulation;

public class MaxTwinSumTest
{
    private MaxTwinSum _engine = new MaxTwinSum();
    private ListNode _head = new ListNode(5,new ListNode(4, new ListNode(2, new ListNode(1))));
    
    [Fact]
    public void ShouldBePositive()
    {
        var result = _engine.PairSum(_head);
        result.Should().Be(6);
    }
}