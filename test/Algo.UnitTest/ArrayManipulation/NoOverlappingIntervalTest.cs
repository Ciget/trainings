using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class NoOverlappingIntervalTest
{
    private NoOverlappingInterval _engine = new NoOverlappingInterval();

    [Fact]
    public void ShouldBeSuccessful()
    {
        int[][] input = new[] {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}, new[] {1, 3}};
        var result = _engine.EraseOverlapIntervals(input);
        result.Should().Be(1);
    }
}