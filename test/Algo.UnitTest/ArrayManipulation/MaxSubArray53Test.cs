using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class MaxSubArray53Test
{
    private MaxSubArray53 _engine = new MaxSubArray53();

    [Fact]
    public void ShouldReturn6()
    {
        int[] input = new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        _engine.MaxSubArray(input).Should().Be(6);
    }
}