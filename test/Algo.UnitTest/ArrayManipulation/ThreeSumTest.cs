using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class ThreeSumTest
{
    private ThreeSum _engine = new ThreeSum();

    [Fact]
    public void ShouldReturn2()
    {
        int[] input = new[] {-1, 0, 1, 2, -1, -4};
        var result = _engine.Sum(input);

        result.Count.Should().Be(2);
        result[0].Should().BeEquivalentTo(new int[] {-1, -1, 2});
        result[1].Should().BeEquivalentTo(new int[] {-1, 0, 1});
    }
}