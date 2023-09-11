using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class RowAndColumnPairTest
{
    private RowAndColumnPair _engine = new RowAndColumnPair();

    [Fact]
    public void ShouldBePositive()
    {
        int[][] test = new int[][]
        {new int[]{ 3, 2, 1}, new int[]{1, 7, 6},new int[]{2, 7, 7}};

        _engine.EqualPairs(test).Should().Be(1);
    }
}