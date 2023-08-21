using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class KidsWithCandiesEngineTest
{
    private KidsWithCandiesEngine _engine = new KidsWithCandiesEngine();

    [Theory]
    [InlineData(new[] {4, 2, 1, 1, 2}, 1, new[] {true, false, false, false, false})]
    [InlineData(new[] {12,1,12}, 10, new[] {true,false,true})]
    public void ShouldBePositive(int[] candies, int extraCandies, bool[] result)
    {
        _engine.KidsWithCandies(candies, extraCandies).Should().Equal(result);
    }
}