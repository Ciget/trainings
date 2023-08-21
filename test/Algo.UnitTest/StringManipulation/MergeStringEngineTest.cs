using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class MergeStringEngineTest
{
    private MergeStringEngine _engine = new MergeStringEngine();

    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void PositiveCase(string word1, string word2, string expectedResult)
    {
        _engine.MergeAlternately(word1, word2).Should().Be(expectedResult);
    }
}