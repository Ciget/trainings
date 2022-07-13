using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class TwoSum167Test
{
    private TwoSum167 _engine = new TwoSum167();
    
    [Fact]
    public void ShouldBe12()
    {
        int[] input = new[] {2, 7, 11, 15};
        _engine.TwoSum(input, 9).Should().Equal(new[] {1, 2});
    }
    
    [Fact]
    public void TargetShouldBe6()
    {
        int[] input = new[] {2,3,4};
        _engine.TwoSum(input, 6).Should().Equal(new[] {1, 3});
    }
    
    [Fact]
    public void TargetShouldBeNegative()
    {
        int[] input = new[] {-1,0};
        _engine.TwoSum(input, -1).Should().Equal(new[] {1,2});
    }
}