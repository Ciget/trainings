using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class GcdOfStringsEngineTest
{
    private GcdOfStringsEngine _engine = new GcdOfStringsEngine();

    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("LEET", "CODE", "")]
    public void ShouldBePositive(string str1, string str2, string result)
    {
        _engine.GcdOfStrings(str1, str2).Should().Be(result);
    }
    
    [Theory]
    [InlineData("LEET", "CODE", "E")]
    public void ShouldBeNegative(string str1, string str2, string result)
    {
        _engine.GcdOfStrings(str1, str2).Should().NotBe(result);
    }
}