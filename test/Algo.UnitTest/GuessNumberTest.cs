using FluentAssertions;

namespace Algo.UnitTest;

public class GuessNumberTest
{
    private GuessNumberGame _engine = new GuessNumberGame();

    [Fact]
    public void ShouldBeSeven()
    {
        var result = _engine.GuessNumber(400).Should().Be(35);
    }
}