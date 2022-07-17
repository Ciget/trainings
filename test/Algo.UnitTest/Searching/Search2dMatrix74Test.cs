using Algo.Searching;
using FluentAssertions;

namespace Algo.UnitTest.Searching;

public class Search2dMatrix74Test
{
    private Search2dMatrix74 _engine = new Search2dMatrix74();

    [Fact]
    public void FindTargetValue()
    {
        int[][] input = new int[3][]{new int[]{1,3,5,7}, new int[]{10,11,16,20}, new int[]{23,30,34,60}};
        _engine.SearchMatrix(input, 3).Should().BeTrue();
    }
    
    [Fact]
    public void NotFindTargetValue()
    {
        int[][] input = new int[3][]{new int[]{1,3,5,7}, new int[]{10,11,16,20}, new int[]{23,30,34,60}};
        _engine.SearchMatrix(input, 32).Should().BeFalse();
    }
}