using Algo.Queue;
using FluentAssertions;

namespace Algo.UnitTest.Queue;

public class KthLargestElementTest
{
    private KthLargestElement _engine = new KthLargestElement();

    [Theory]
    [InlineData(new int[]{3,2,1,5,6,4}, 2, 5)]
    [InlineData(new int[]{3,2,3,1,2,4,5,5,6}, 4, 4)]
    public void ShouldBePositive(int[] nums, int k, int result)
    {
        _engine.FindKthLargest(nums, k).Should().Be(result);
    }
}