using Algo.DynamicProgramming;
using FluentAssertions;

namespace Algo.UnitTest.DynamicProgramming;

public class MinCostClimbingTest
{
    private MinCostClimbing engine = new MinCostClimbing();
    
    [Fact]
    public void ShouldFindPath()
    {
        int[] cost = new []{ 10,15,20 };

        engine.MinCostClimbingStairs(cost).Should().Be(15);
    }
    
    [Fact]
    public void ShouldFindPath2()
    {
        int[] cost = new []{ 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };

        engine.MinCostClimbingStairs(cost).Should().Be(6);
    }
}