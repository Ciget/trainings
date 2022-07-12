using Algo.SortingArray;
using FluentAssertions;

namespace Algo.UnitTest.SortingArray;

public class QuickSortTest
{
    private readonly QuickSort _engine = new QuickSort();

    [Fact]
    public void ShouldBeEqualOutput()
    {
        _engine.Sort(new int[]{10,-1,8,3,1}).Should().Equal(new int[]{ -1, 1, 3, 8, 10});
    }  
    
    [Fact]
    public void ShouldBeEqualOutput2()
    {
        _engine.Sort(new int[]{9, 1, 8, 2, 7, 4, 3}).Should().Equal(new int[]{ 1, 2, 3, 4, 7, 8, 9});
    }  
}