using Algo.SortingArray;
using FluentAssertions;

namespace Algo.UnitTest;

public class SquaresSortedArray977Test
{
    private readonly SquaresSortedArray977 _engine = new SquaresSortedArray977();

    [Fact]
    public void ShouldBeEqualOutput()
    {
        _engine.SortedSquares(new int[]{-4,-1,0,3,10}).Should().Equal(new int[]{ 0,1,9,16,100});
    }    
    
    [Fact]
    public void ShouldBeEqualOutput2()
    {
        _engine.SortedSquares(new int[]{-7,-3,2,3,11}).Should().Equal(new int[]{4,9,9,49,121});
    }
}