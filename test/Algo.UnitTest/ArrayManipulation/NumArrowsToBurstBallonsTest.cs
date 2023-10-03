using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class NumArrowsToBurstBallonsTest
{
    private NumArrowsToBurstBallons _engine = new NumArrowsToBurstBallons();

    [Fact]
    public void ShouldBePositive()
    {
        var input = new[] {new int[] {10, 16}, new int[] {2, 8}, new int[] {1, 6},new int []{7, 12}};
        _engine.FindMinArrowShots(input).Should().Be(2);
    }
    
    [Fact]
    public void ShouldBePositive2()
    {
        var input = new[] {new int[] {1, 2}, new int[] {3, 4}, new int[] {5, 6},new int []{7, 8}};
        _engine.FindMinArrowShots(input).Should().Be(4);
    }
}