using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class CanPlaceFlowersEngineTest
{
    CanPlaceFlowersEngine _engine = new CanPlaceFlowersEngine();
    
    [Theory]
    [InlineData(new[] {1, 0, 0, 0, 1}, 1)]
    [InlineData(new[] {1,0,0,0,1,0,0}, 2)]
    public void ShouldBePositive(int[] flowerbed, int n)
    {
        _engine.CanPlaceFlowers(flowerbed, n).Should().BeTrue();
    }

    [Theory]
    [InlineData(new[] {1, 0, 0, 0, 1}, 2)]
    public void ShouldBeNegative(int[] flowerbed, int n)
    {
        _engine.CanPlaceFlowers(flowerbed, n).Should().BeFalse();
    }
}