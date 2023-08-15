using Algo.LinkedListManipulation;
using FluentAssertions;

namespace Algo.UnitTest.LinkedListManipulation;

public class AddTwoNumbersTest
{
    private AddTwoNumbers _engine = new AddTwoNumbers();
    
    [Fact]
    public void ShouldSumSuccessfully()
    {
        _engine = new AddTwoNumbers();
        var l1 = CreateNode(new int[]{2,4,3});
        var l2 = CreateNode(new int[]{5,6,4});
        _engine.AddTwoNumbers(l1, l2);
    }

    private ListNode CreateNode(int [] x, int i=0)
    {
        if (i >= x.Length) return null;
        
        return new ListNode(x[i], CreateNode(x, i++));
    }
}