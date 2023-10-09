using Algo.Queue;
using FluentAssertions;

namespace Algo.UnitTest.Queue;

public class SmallestInfiniteSetTest
{
    private SmallestInfiniteSet _engine = new SmallestInfiniteSet();

    [Fact]
    public void ShouldBePositive()
    {
        SmallestInfiniteSet smallestInfiniteSet = new SmallestInfiniteSet();
        smallestInfiniteSet.AddBack(2);
        smallestInfiniteSet.PopSmallest().Should().Be(1);
        smallestInfiniteSet.PopSmallest().Should().Be(2);
        smallestInfiniteSet.PopSmallest().Should().Be(3);
        smallestInfiniteSet.AddBack(1);
        smallestInfiniteSet.PopSmallest().Should().Be(1);
        // is the smallest number, and remove it from the set.
        smallestInfiniteSet.PopSmallest().Should().Be(4);
        smallestInfiniteSet.PopSmallest().Should().Be(5);
    }
}