using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class LetterCombinationOnPhoneTest
{
    private LetterCombinationOnPhone _engine = new LetterCombinationOnPhone();
    [Fact]
    public void ShouldBePositive()
    {
        var expectedResult = new List<string>(new[] {"ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"});
        var result = _engine.LetterCombinations("23");
            result.Should()
            .BeEquivalentTo(expectedResult);
    }
}