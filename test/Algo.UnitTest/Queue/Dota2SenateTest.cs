using Algo.Queue;
using FluentAssertions;

namespace Algo.UnitTest.Queue;

public class Dota2SenateTest
{
    private Dota2Senate _engine = new Dota2Senate();

    [Theory]
    [InlineData("RD", "Radiant")]
    [InlineData("RDD", "Dire")]
    public void ShouldBePositive(string senators, string result)
    {
        _engine.PredictPartyVictory(senators).Should().Be(result);
    }

}