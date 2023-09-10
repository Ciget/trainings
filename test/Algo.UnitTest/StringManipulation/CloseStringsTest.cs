using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class CloseStringsTest
{
    private CloseStringsEngine _engine = new CloseStringsEngine();

    [Theory]
    [InlineData("abc", "bca", true)]
    [InlineData("a", "aa", false)]
    [InlineData("cabbba", "abbccc", true)]
    public void ShouldBePositive(string word1, string word2, bool result)
    {
        _engine.CloseStrings(word1, word2).Should().Be(result);
    }
}