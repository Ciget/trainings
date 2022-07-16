using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class IntersectionOf2Arrays350Test
{
    private IntersectionOf2Arrays350 _engine = new IntersectionOf2Arrays350();

    [Fact]
    public void ShouldMerge()
    {
        int[] input1 = new[] {1, 2, 2, 1};
        int[] input2 = new[] {2,2};
        _engine.Intersect(input1, input2).Should().Equal(new []{2,2});
    }
}