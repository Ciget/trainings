using FluentAssertions;

namespace Algo.UnitTest;

public class MinCostClimbingStairsTest
{
    private MinCostClimbingSteps _engine = new MinCostClimbingSteps();

    [Theory]
    [InlineData(new  []{ 10,15,20}, 15)]
    public void ShouldBePositive(int [] costs, int result)
    {
        _engine.MinCostClimbingStairs(costs).Should().Be(result);
    }

}