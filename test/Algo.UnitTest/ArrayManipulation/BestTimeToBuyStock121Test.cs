using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class BestTimeToBuyStock121Test
{
    private BestTimeToBuyStock121 _engine = new BestTimeToBuyStock121();

    [Fact]
    public void ShouldFindTimePositive()
    {
        int[] input = new[] {7, 1, 5, 3, 6, 4};

        _engine.MaxProfit(input).Should().Be(5);
    }
    
    [Fact]
    public void ShouldBeNoProfit()
    {
        int[] input = new[] {7,6,4,3,1};

        _engine.MaxProfit(input).Should().Be(0);
    }
}