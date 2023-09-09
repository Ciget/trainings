using Algo.Stack;
using FluentAssertions;

namespace Algo.UnitTest.Stack;

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