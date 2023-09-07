using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class RemovingStarsEngineTest
{
    private RemovingStars _engine = new RemovingStars();

    [Theory]
    [InlineData("leet**cod*e", "lecoe")]
    public void ShouldBePositive(string input, string result)
    {
        _engine.RemoveStars(input).Should().Be(result);
    }
}