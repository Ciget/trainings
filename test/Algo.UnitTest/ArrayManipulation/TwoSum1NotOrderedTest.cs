using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class TwoSum1NotOrderedTest
{
    private TwoSum167 _engine = new TwoSum167();
    
    [Fact]
    public void ShouldBe()
    {
        int[] input = new[] {2,7,11,15};
        _engine.TwoSumNotSorter(input, 9).Should().Equal(new[] {0, 1});
    }
    
    [Fact]
    public void ShouldBeNotOrdered()
    {
        int[] input = new[] {3,2,4};
        _engine.TwoSumNotSorter(input, 6).Should().Equal(new[] {1, 2});
    }
}