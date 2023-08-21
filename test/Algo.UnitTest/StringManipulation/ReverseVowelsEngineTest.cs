using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class ReverseVowelsEngineTest
{
    private ReverseVowelsEngine _engine = new ReverseVowelsEngine();

    [Theory]
    [InlineData("hello", "holle")]
    [InlineData("leetcode", "leotcede")]
    [InlineData("ai", "ia")]
    [InlineData("aA", "Aa")]
    [InlineData("race car", "race car")]
    public void ShouldBePositive(string str, string result)
    {
        _engine.ReverseVowels(str).Should().Be(result);
    }
}